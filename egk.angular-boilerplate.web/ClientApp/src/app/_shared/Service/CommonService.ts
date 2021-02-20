import { compare, Operation } from "fast-json-patch";

export class CommonService {
  createPatch (orginalObject : Object, modelObject: Object) : Operation[]  {
    const updatedProduct = {...orginalObject , ...modelObject};
    return compare(orginalObject, updatedProduct);

  }
}
