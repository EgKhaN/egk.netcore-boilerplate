import { BaseModel } from "./BaseModel";

export class AuditableModel extends BaseModel {
    CreatedDate: Date;
    CreatedBy: string;
    ModifiedDate: Date;
    ModifiedBy: string;
    DeletedDate: Date;
    DeletedBy: string;
    Version: any;
}
