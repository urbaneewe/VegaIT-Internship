import React from 'react';
import { Link, useLocation } from 'react-router-dom';

export const Header = () => {
    const location = useLocation();
    const getActiveRoute = (route: string) => {
        if (route === location.pathname) {
            return 'navigation__button--active';
        }

        return '';
    };

    const [isMenuOpen, setIsMenuOpen] = React.useState(false);

    return (
        <header className="header">
            <div className="inner-wrap">
                <Link to="/timesheet" className="logo">
                    <img src="logo-white.png" alt="Logo" />
                </Link>
                <nav className="navigation">
                    <button
                        style={{ zIndex: 100 }}
                        id="navigation__link"
                        type="button"
                        className="navigation__link"
                        onClick={() => setIsMenuOpen(!isMenuOpen)}
                    >
                        <span
                            id="navigation__text"
                            className={`nav-toggle ${
                                isMenuOpen ? 'nav-toggle-open' : ''
                            }`}
                        ></span>
                    </button>
                    <ul
                        className={`navigation__menu ${
                            isMenuOpen ? 'nav-toggle-open' : ''
                        }`}
                    >
                        <li className="navigation__list">
                            <Link
                                to="/timesheet"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/timesheet'
                                )}`}
                            >
                                Timesheet
                            </Link>
                        </li>
                        <li className="navigation__list">
                            <Link
                                to="/clients"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/clients'
                                )}`}
                            >
                                Clients
                            </Link>
                        </li>
                        <li className="navigation__list">
                            <Link
                                to="/projects"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/projects'
                                )}`}
                            >
                                Projects
                            </Link>
                        </li>
                        <li className="navigation__list">
                            <Link
                                to="/categories"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/categories'
                                )}`}
                            >
                                Categories
                            </Link>
                        </li>
                        <li className="navigation__list">
                            <Link
                                to="/employees"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/employees'
                                )}`}
                            >
                                Employees
                            </Link>
                        </li>
                        <li className="navigation__list">
                            <Link
                                to="/reports"
                                className={`btn navigation__button ${getActiveRoute(
                                    '/reports'
                                )}`}
                            >
                                Reports
                            </Link>
                        </li>
                    </ul>
                </nav>
                <div className="user">
                    <div className="user__nav">
                        <h2 className="user__name">Ognjen Adamović</h2>
                        <ul className="user__dropdown">
                            <li className="user__list">
                                <a className="user__link" href="javascript:;">
                                    Change password
                                </a>
                            </li>
                            <li className="user__list">
                                <a className="user__link" href="javascript:;">
                                    Settings
                                </a>
                            </li>
                            <li className="user__list">
                                <a className="user__link" href="javascript:;">
                                    Export all data
                                </a>
                            </li>
                        </ul>
                    </div>
                    <ul>
                        <li className="logout">
                            <a className="logout__link" href="javascript:;">
                                Logout
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </header>
    );
};
