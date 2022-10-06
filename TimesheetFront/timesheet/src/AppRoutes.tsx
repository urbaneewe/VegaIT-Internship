import { Route, Routes } from 'react-router';
import { Categories } from './pages/Categories/Categories';
import { Clients } from './pages/Clients/Clients';
import { Days } from './pages/Days/Days';
import { Employees } from './pages/Employees/Employees';
import { ForgotPassword } from './pages/ForgotPassword/ForgotPassword';
import { Login } from './pages/Login/Login';
import { Projects } from './pages/Projects/Projects';
import { Reports } from './pages/Reports/Reports';
import { Timesheet } from './pages/Timesheet/Timesheet';

export const AppRoutes = () => {
    return (
        <Routes>
            <Route element={<Timesheet />} path="/timesheet" />
            <Route element={<Clients />} path="/clients" />
            <Route element={<Reports />} path="/reports" />
            <Route element={<Projects />} path="/projects" />
            <Route element={<Login />} path="/login" />
            <Route element={<ForgotPassword />} path="/forgot-password" />
            <Route element={<Employees />} path="/employees" />
            <Route element={<Days />} path="/days" />
            <Route element={<Categories />} path="/categories" />
            <Route element={<Timesheet />} path="*" />
        </Routes>
    );
};
