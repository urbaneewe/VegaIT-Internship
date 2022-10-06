import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';

export const Reports = () => {
    return (
        <>
            <div className="container">
                <Header />
                <div className="wrapper">
                    <section className="content">
                        <div className="main-content">
                            <h2 className="main-content__title">Reports</h2>
                            <form className="reports" action="javascript:;">
                                <ul className="reports__form">
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Client
                                        </label>
                                        <select className="reports__select">
                                            <option value="">All</option>
                                            <option value="223">
                                                Internal
                                            </option>
                                            <option value="241">
                                                Internal
                                            </option>
                                            <option value="300">
                                                Internal
                                            </option>
                                            <option value="1341">
                                                Internal
                                            </option>
                                        </select>
                                    </li>
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Project
                                        </label>
                                        <select className="reports__select">
                                            <option value="">All</option>
                                            <option value="">All</option>
                                            <option value="">All</option>
                                            <option value="">All</option>
                                            <option value="">All</option>
                                        </select>
                                    </li>
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Category:
                                        </label>
                                        <select className="reports__select">
                                            <option value="">All</option>
                                        </select>
                                    </li>
                                </ul>
                                <ul className="reports__form">
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Employee
                                        </label>
                                        <select className="reports__select">
                                            <option value="2723">
                                                Ognjen Adamović
                                            </option>
                                        </select>
                                    </li>
                                </ul>
                                <ul className="reports__form">
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Quick date:
                                        </label>
                                        <select className="reports__select">
                                            <option value="">
                                                Select week
                                            </option>
                                            <option value="1">Next week</option>
                                            <option value="2">This week</option>
                                            <option value="3">Last week</option>
                                        </select>
                                    </li>
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Quick date:
                                        </label>
                                        <select className="reports__select">
                                            <option value="">
                                                Select month
                                            </option>
                                            <option value="1">
                                                Next month
                                            </option>
                                            <option value="2">
                                                This month
                                            </option>
                                            <option value="3">
                                                Last month
                                            </option>
                                        </select>
                                    </li>
                                    <li className="reports__list">
                                        <label className="report__label">
                                            Start date
                                        </label>
                                        <input
                                            type="date"
                                            className="in-text"
                                        />
                                    </li>
                                    <li className="reports__list">
                                        <label className="report__label">
                                            End date
                                        </label>
                                        <input
                                            type="date"
                                            className="in-text"
                                        />
                                    </li>
                                </ul>
                                <div className="reports__buttons">
                                    <button
                                        type="submit"
                                        className="btn btn--green"
                                    >
                                        Search
                                    </button>
                                    <button
                                        type="submit"
                                        className="btn btn--green"
                                    >
                                        Search Overtime
                                    </button>
                                    <button
                                        type="button"
                                        className="btn btn--green"
                                    >
                                        Reset
                                    </button>
                                </div>
                            </form>
                            <div className="table-wrapper">
                                <table className="projects-table">
                                    <thead>
                                        <tr>
                                            <th className="small">
                                                <span>Date</span>
                                            </th>
                                            <th className="small">
                                                <span>Employees</span>
                                            </th>
                                            <th className="small">
                                                <span>Projects</span>
                                            </th>
                                            <th className="small">
                                                <span>Categories</span>
                                            </th>
                                            <th className="small">
                                                <span>Description</span>
                                            </th>
                                            <th className="small">
                                                <span>Time</span>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>14.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>14.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Learning</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>15.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>15.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Learning</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>16.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>16.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Learning</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>17.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>17.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Learning</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>18.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>18.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Learning</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                        <tr>
                                            <td>21.12.2020.</td>
                                            <td>Ognjen Adamović</td>
                                            <td>Internal</td>
                                            <td>Internal</td>
                                            <td>Front-end Development</td>
                                            <td>7.5</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div className="table-navigation">
                                <div className="table-navigation__next">
                                    <span className="table-navigation__text">
                                        Reports Total:
                                    </span>
                                    <span>352.0</span>
                                </div>
                            </div>
                            <div className="reports__buttons-bottom">
                                <a
                                    href="javascript:;"
                                    className="btn btn--transparent"
                                >
                                    Print Report
                                </a>
                                <a
                                    href="javascript:;"
                                    className="btn btn--transparent"
                                >
                                    Create PDF
                                </a>
                                <a
                                    href="javascript:;"
                                    className="btn btn--transparent"
                                >
                                    Export to excel
                                </a>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <Footer />
        </>
    );
};
