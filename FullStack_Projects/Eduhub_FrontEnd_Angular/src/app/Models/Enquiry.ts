// enquiry.model.ts
export interface Enquiry {
    enquiryId: number;
    courseId: number;
    userId: number;
    subject?: string;
    message: string;
    enquiryDate: Date;
    status?: string;
    response?: string;
  }
  