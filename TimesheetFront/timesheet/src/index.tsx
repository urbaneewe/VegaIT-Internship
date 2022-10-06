import { configureStore } from '@reduxjs/toolkit';
import { StrictMode } from 'react';
import ReactDOM from 'react-dom/client';
import { Provider } from 'react-redux';
import createSagaMiddleware from 'redux-saga';
import App from './App';
import './index.css';
import clientReducer from './pages/Clients/clientReducer';
import clientSaga from './pages/Clients/clientSaga';
import countryReducer from './pages/Clients/countryReducer';
import reportWebVitals from './reportWebVitals';

const saga = createSagaMiddleware();

const store = configureStore({
    reducer: {
        clients: clientReducer,
        countries: countryReducer,
    },
    middleware: [saga],
});

saga.run(clientSaga);

const root = ReactDOM.createRoot(
    document.getElementById('root') as HTMLElement
);
root.render(
    <StrictMode>
        <Provider store={store}>
            <App />
        </Provider>
    </StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
