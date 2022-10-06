import { getClientsRequested, getClientsReceived, addClientRequested, addClientReceived } from "./clientReducer";
import { call, put, takeEvery} from "redux-saga/effects";
import { getClients, insertClient, getCountries } from "./clientsService";
import { getCountriesReceived, getCountriesRequested } from "./countryReducer";
import { Client } from './client';

function* fetchCountries(): any {
    const countries = yield call(getCountries);

    const countriesData = yield countries.json();
    yield put(getCountriesReceived(countriesData));
}

function* fetchClients(): any {
    const clients = yield call(getClients);

    const clientsData = yield clients.json();
    yield put(getClientsReceived(clientsData));
}

function* insertClients(client: Client): any {
    const clients = yield call(insertClient);

    const clientsData = yield clients.json();
    yield put(addClientReceived(clientsData));
}

function* clientSaga(){
    yield takeEvery(getCountriesRequested.type, fetchCountries);
    yield takeEvery(getClientsRequested.type, fetchClients);
    // yield takeEvery(addClientRequested.type, insertClients());
}

export default clientSaga;