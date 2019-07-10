import { PageBuilder } from "./builder";
import { Company } from "./company";

declare global {
  interface Window {
    kentico: {
      pageBuilder: PageBuilder
    },
    Company: Company,
  }
}