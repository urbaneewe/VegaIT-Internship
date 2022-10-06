import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { Client } from "./client";

interface ClientState {
    clients: Client[]
    isLoading: boolean
};

const initialState: ClientState = {
    clients: [],
    isLoading: false
};

export const clientSlice = createSlice({
    name: 'clients',
    initialState,
    reducers: {
        getClientsRequested: (state) => {
            state.isLoading = true;
        },
        
        getClientsReceived: (state, action: PayloadAction<Client[]>) => {
            state.clients = action.payload;
            state.isLoading = false;
        },

        getClientsFailure: (state)=>{
            state.isLoading = false;
        },

        //*Dodati clientToAdd state i pristupiti iz sage
        addClientRequested: (state) => {
            state.isLoading = true;
        },

        clientToAdd:(state, action) => {
            state.clients = action.payload
        },

        addClientReceived: (state, action: PayloadAction<Client>) => {
            state.clients = [...state.clients, action.payload]; //*uzima ceo niz i dodaje jos jednog novog
            state.isLoading = false;
        },

        addClientFailure: (state) => {
            state.isLoading = false;
        }
    }
})

export const {getClientsRequested, getClientsReceived, getClientsFailure, addClientRequested, addClientReceived, addClientFailure} = clientSlice.actions;
export default clientSlice.reducer;
