import { Kentico } from "./kentico";
import { MyCompany } from "./my-company";

declare global {
  interface Window {
    readonly kentico: Kentico,
    readonly myCompany: MyCompany,
  }

  type Mutable<T> = {
    -readonly [P in keyof T]: T[P] extends ReadonlyArray<infer U> ? Mutable<U>[] : Mutable<T[P]>
  };
}
