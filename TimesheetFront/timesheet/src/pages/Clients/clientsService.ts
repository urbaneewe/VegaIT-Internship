export const getCountries = () => fetch('https://localhost:7263/api/Country/GetAll');

export const getClients = () => fetch('https://localhost:7263/api/Client/GetAll');//*axios pogledati

export const insertClient = () => fetch('https://localhost:7263/api/Client/Insert');