import { Invitation } from './Invitation';

export interface Data {
  PageSize: number;
  IndexFrom: number;
  PageIndex: number;
  TotalCount: number;
  TotalPages: number;
  HasNextPage: boolean;
  HasPreviousPage: boolean;
  Items: Invitation[];
}
