import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { Country } from "./country"

interface CountryState {
    countries: Country[],
    isLoading: boolean
};

const initialState: CountryState ={
    countries: [],
    isLoading: false
};

export const countrySlice = createSlice({
    name: 'countries',
    initialState,
    reducers: {
        getCountriesRequested: (state) => {
            state.isLoading = true;
        },

        getCountriesReceived: (state, action: PayloadAction<Country[]>) => {
            state.countries = action.payload;
            state.isLoading = false;
        },

        getCountriesFailure: (state) => {
            state.isLoading = false;
        }
    }
})

export const {getCountriesRequested, getCountriesReceived, getCountriesFailure} = countrySlice.actions;
export default countrySlice.reducer;