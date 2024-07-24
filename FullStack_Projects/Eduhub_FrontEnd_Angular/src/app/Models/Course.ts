// course.model.ts
export interface Course {
    courseId: number;
    title?: string;
    description?: string;
    courseStartDate: Date;
    courseEndDate: Date;
    userId: number;
    category?: string;
    level?: string;
  }
  