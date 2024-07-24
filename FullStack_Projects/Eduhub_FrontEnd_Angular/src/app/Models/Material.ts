// material.model.ts
export interface Material {
    materialId: number;
    courseId: number;
    title?: string;
    description?: string;
    url?: string;
    uploadDate: Date;
    contentType?: string;
  }
  