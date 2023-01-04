import { Address } from './Address';
import { Contact } from './Contact';
import { Email } from './Email';

export interface Invitation {
  ContactId: number;
  Contact: Contact;
  Address: Address;
  Email: Email;
  Category: number;
  CategoryDescription: string
  Price: number;
  Description: string;
  Status: any;
  Id: number;
  CreateDate: string;
  Active: boolean;
}
