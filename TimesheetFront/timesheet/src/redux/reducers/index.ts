import { combineReducers } from "redux";
import clientReducer from "../../pages/Clients/clientReducer";
import countryReducer from "../../pages/Clients/countryReducer";

//*Add reducers as you create them
const rootReducer = combineReducers({
    clients: clientReducer,
    countries: countryReducer
});

export default rootReducer;