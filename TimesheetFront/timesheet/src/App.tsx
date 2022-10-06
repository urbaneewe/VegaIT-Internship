import { BrowserRouter } from 'react-router-dom';
import './App.css';
import { AppRoutes } from './AppRoutes';
import './styles/style.scss';

function App() {
    return (
        <BrowserRouter>
            <AppRoutes />
        </BrowserRouter>
    );
}

export default App;
