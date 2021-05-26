import { BaseModel } from "../_shared/Model/BaseModel";

export class Task extends BaseModel {
  // public Id: number:;
  public Title: string;
  public Description: string;
  public PriorityId: number; // low,normal,high
  public TypeId: number; // Bug,request,manumberanience,
  public StatusId: number; // ToDo,Ongoing
  public DueDate: Date;
  public BackLogId: number;
  public ParentId: number;
  public AssignedUserId: number;
  public TaskGroupId: number; // Errors,Issues,Requests
  public CustomerId: number;
  public DepartmentId: number;
  public RelevantPlaceId: number; // task neeyreyle alakaa
  public WorkItemId: number;
  public Order: number;
  public WorkItemUrl: string;
  public Color: string;
  public Note: string;
  public LastSolvedById: number;
  public LastApprovedById: number;
  public LastClosedDate: Date;
  public LastClosedBy: string;
  public IsDone: boolean;
}
