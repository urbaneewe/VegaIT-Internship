import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';

export const Days = () => {
    return (
        <>
            <Header />
            <div className="wrapper">
                <section className="content">
                    <form
                        id="mainContent"
                        className="main-content"
                        action="javascript"
                    >
                        <h2 className="main-content__title">Timesheet</h2>
                        <div className="table-navigation">
                            <a
                                href="javascript:;"
                                className="table-navigation__prev"
                            >
                                <span>previous week</span>
                            </a>
                            <span className="table-navigation__center">
                                September 06 - September 12, 2021 (week 36)
                            </span>
                            <a
                                href="javascript:;"
                                className="table-navigation__next"
                            >
                                <span>next week</span>
                            </a>
                        </div>
                        <div className="day-table">
                            <ul className="day-table__wrap">
                                <li className="day-table__list day-table__list--active">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 06
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Monday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Mon
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 07
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Tuesday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Tue
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 08
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Wednesday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Wed
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 09
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Thursday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Thu
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 10
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Friday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Fri
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 11
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Saturday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Mon
                                        </span>
                                    </a>
                                </li>
                                <li className="day-table__list">
                                    <a
                                        href="javascript:;"
                                        className="day-table__link"
                                    >
                                        <b className="day-table__month">
                                            Sep 12
                                        </b>{' '}
                                        <i className="day-table__day">0</i>
                                        <span className="day-table__span hide-on-mob">
                                            Sunday
                                        </span>
                                        <span className="day-table__span show-on-mob">
                                            Mon
                                        </span>
                                    </a>
                                </li>
                            </ul>
                        </div>
                        <table className="project-table">
                            <thead>
                                <tr className="project-table__top">
                                    <th className="project-table__title">
                                        Client *
                                    </th>
                                    <th className="project-table__title">
                                        Project *
                                    </th>
                                    <th className="project-table__title">
                                        Category *
                                    </th>
                                    <th className="project-table__title project-table__title--large">
                                        Description
                                    </th>
                                    <th className="project-table__title project-table__title--small">
                                        Hours *
                                    </th>
                                    <th className="project-table__title project-table__title--small">
                                        Overtime
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option>Choose client</option>
                                            <option>Client name 1</option>
                                            <option>Client name 2</option>
                                            <option>Client name 3</option>
                                            <option>Client name 4</option>
                                        </select>
                                    </td>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option value="">
                                                Choose project
                                            </option>
                                            <option value="">
                                                Choose category
                                            </option>
                                        </select>
                                    </td>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option value="">
                                                Choose category
                                            </option>
                                            <option value="">
                                                Choose category
                                            </option>
                                        </select>
                                        <span
                                            className="validationMessage"
                                            style={{ display: 'none' }}
                                        ></span>
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text medium"
                                        />
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </td>
                                </tr>
                                <tr>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option>Choose client</option>
                                            <option>Client name 1</option>
                                            <option>Client name 2</option>
                                            <option>Client name 3</option>
                                            <option>Client name 4</option>
                                        </select>
                                    </td>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option value="">
                                                Choose project
                                            </option>
                                            <option value="">
                                                Choose category
                                            </option>
                                        </select>
                                    </td>
                                    <td className="project-table__name">
                                        <select className="project-table__select">
                                            <option value="">
                                                Choose category
                                            </option>
                                            <option value="">
                                                Choose category2
                                            </option>
                                        </select>
                                        <span
                                            className="validationMessage"
                                            style={{ display: 'none' }}
                                        ></span>
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text medium"
                                        />
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </td>
                                    <td className="project-table__name">
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <div className="table-navigation">
                            <a
                                href="javascript:;"
                                className="table-navigation__prev"
                            >
                                <span>back to monthly view</span>
                            </a>
                            <div className="table-navigation__next">
                                <span className="table-navigation__text">
                                    Total:
                                </span>
                                <span>7.5</span>
                            </div>
                        </div>
                        <div className="btn-wrap">
                            <button type="submit" className="btn btn--green">
                                <span>Save changes</span>
                            </button>
                        </div>
                    </form>
                </section>
            </div>
            <Footer />
        </>
    );
};
