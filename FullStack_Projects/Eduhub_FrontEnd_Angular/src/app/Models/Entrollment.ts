// enrollment.model.ts
export interface Enrollment {
    enrollmentId: number;
    userId: number;
    courseId: number;
    enrollmentDate: Date;
    status?: string;
  }
  