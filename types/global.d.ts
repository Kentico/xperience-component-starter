import { Kentico } from "./kentico";
import { MyCompany } from "./company";

declare global {
  interface Window {
    kentico: Kentico,
    MyCompany: MyCompany,
  }
}