import * as generated from "./api.generated";
import config from "./config";

const clients = {
    books: new generated.BooksClient(config.API_URL)
}

export default clients;