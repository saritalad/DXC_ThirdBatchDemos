using EduHub_Project.Models;
using EduHub_Project.repository;
using EduHub_Project.services;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace EduHubTestProject
{
    public class UserRepositoryTests
    {
        private readonly UserRepository _userRepository;
        private readonly AppDbContext _context;

        public UserRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
            _context = new AppDbContext(options);
            _userRepository = new UserRepository(_context);

        }
        [Fact]
        public async Task GetUserAsync_ReturnsUser_WhenUserExists()
        {
            var userId = 1;
            var user = new User { UserId = userId };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userRepository.GetUserAsync(userId);

            // Assert
            Assert.Equal(user, result);
        }
        [Fact]
        public async Task GetAllStudentsAsync_ReturnsStudents()
        {
            // Arrange
            var students = new List<User>
        {
            new User { UserId = 1, UserRole = "Student" },
            new User { UserId = 2, UserRole = "Student" }
        };
            await _context.Users.AddRangeAsync(students);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userRepository.GetAllStudentsAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.All(result, u => Assert.Equal("Student", u.UserRole));
        }
        [Fact]
        public async Task CreateUserAsync_AddsUserToContext()
        {
            // Arrange
            var newUser = new User { UserId = 1 };

            // Act
            var result = await _userRepository.CreateUserAsync(newUser);

            // Assert
            var userInDb = await _context.Users.FindAsync(newUser.UserId);
            Assert.Equal(newUser, userInDb);
        }
        [Fact]
        public async Task UpdateUserAsync_ReturnsUpdatedUser_WhenUserExists()
        {
            // Arrange
            var userId = 1;
            var existingUser = new User { UserId = userId, Email = "oldemail@example.com" };
            await _context.Users.AddAsync(existingUser);
            await _context.SaveChangesAsync();

            var updatedUser = new User { Email = "newemail@example.com" };

            // Act
            var result = await _userRepository.UpdateUserAsync(userId, updatedUser);

            // Assert
            Assert.Equal("newemail@example.com", result.Email);
        }
        [Fact]
        public async Task DeleteUserAsync_ReturnsTrue_WhenUserIsDeleted()
        {
            // Arrange
            var userId = 1;
            var user = new User { UserId = userId };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            // Act
            var result = await _userRepository.DeleteUserAsync(userId);

            // Assert
            Assert.True(result);
            var deletedUser = await _context.Users.FindAsync(userId);
            Assert.Null(deletedUser);
        }
    }
}