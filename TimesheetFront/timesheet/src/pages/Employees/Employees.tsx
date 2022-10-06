import React from 'react';
import { Accordion } from '../../shared/components/Accordion';
import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';
import { Modal } from '../../shared/components/Modal';
import { Pagination } from '../../shared/components/Pagination';

export const Employees = () => {
    const [isModalOpen, setIsModalOpen] = React.useState(false);

    return (
        <>
            <div className="container">
                <Header />
                {isModalOpen && (
                    <Modal
                        title="Create new employee"
                        onClose={() => setIsModalOpen(false)}
                    >
                        <form className="info" action="javascript">
                            <div className="info__form">
                                <ul className="info__wrapper">
                                    <li className="info__list">
                                        <label className="info__label">
                                            Name:
                                        </label>
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </li>
                                    <li className="info__list">
                                        <label className="report__label">
                                            Username:
                                        </label>
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </li>
                                    <li className="info__list">
                                        <label className="report__label">
                                            Hours per week:
                                        </label>
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </li>
                                    <li className="info__list">
                                        <label className="report__label">
                                            Email:
                                        </label>
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </li>
                                    <li className="radio-button__wrapper">
                                        <ul className="info__list-wrapper">
                                            <li className="info__list-title">
                                                <h4 className="radio-button__title">
                                                    Status:
                                                </h4>
                                            </li>
                                            <li className="info__list-radio-button">
                                                <input
                                                    type="radio"
                                                    id="rdo1"
                                                    defaultChecked={true}
                                                    className="radio-input"
                                                    name="radio-group-status"
                                                />
                                                <label
                                                    htmlFor="rdo1"
                                                    className="radio-label"
                                                >
                                                    {' '}
                                                    <span className="radio-border"></span>
                                                    Active
                                                </label>
                                            </li>
                                            <li className="info__list-radio-button">
                                                <input
                                                    type="radio"
                                                    className="radio-input"
                                                    name="radio-group-status"
                                                />
                                                <label
                                                    htmlFor="rdo1"
                                                    className="radio-label"
                                                >
                                                    {' '}
                                                    <span className="radio-border"></span>
                                                    Inactive
                                                </label>
                                            </li>
                                        </ul>
                                        <ul className="info__list-wrapper">
                                            <li className="info__list-title">
                                                <h4 className="radio-button__title">
                                                    Role:
                                                </h4>
                                            </li>
                                            <li className="info__list-radio-button">
                                                <input
                                                    type="radio"
                                                    id="rdo2"
                                                    defaultChecked={true}
                                                    className="radio-input"
                                                    name="radio-group-role"
                                                />
                                                <label
                                                    htmlFor="rdo2"
                                                    className="radio-label"
                                                >
                                                    {' '}
                                                    <span className="radio-border"></span>
                                                    Admin
                                                </label>
                                            </li>
                                            <li className="info__list-radio-button">
                                                <input
                                                    type="radio"
                                                    className="radio-input"
                                                    name="radio-group-role"
                                                />
                                                <label
                                                    htmlFor="rdo2"
                                                    className="radio-label"
                                                >
                                                    {' '}
                                                    <span className="radio-border"></span>
                                                    Worker
                                                </label>
                                            </li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                            <div className="btn-wrap">
                                <button
                                    type="submit"
                                    className="btn btn--green"
                                >
                                    <span>Invite an employee</span>
                                </button>
                            </div>
                        </form>
                    </Modal>
                )}
                <div className="wrapper">
                    <section className="content">
                        <div className="main-content">
                            <h2 className="main-content__title">Employees</h2>
                            <div className="table-navigation">
                                <a
                                    href="javascript:;"
                                    className="table-navigation__create btn-modal"
                                    onClick={() => {
                                        setIsModalOpen(true);
                                    }}
                                >
                                    <span>Create new employee</span>
                                </a>
                            </div>
                            <Accordion title="Sladjana Miljanovic">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Username:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Hours per week:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Email:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Status:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        defaultChecked={true}
                                                        className="radio-input"
                                                        name="radio-group-status-second"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Active
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group-status-second"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Inactive
                                                    </label>
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Role:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        defaultChecked={true}
                                                        className="radio-input"
                                                        name="radio-group-role-second"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Admin
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group-role-second"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Worker
                                                    </label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div className="btn-wrap">
                                        <button
                                            type="submit"
                                            className="btn btn--green"
                                        >
                                            <span>Save changes</span>
                                        </button>
                                        <button
                                            type="button"
                                            className="btn btn--red"
                                        >
                                            <span>Delete</span>
                                        </button>
                                        <button
                                            type="button"
                                            className="btn btn--orange"
                                        >
                                            <span>Change passwword</span>
                                        </button>
                                    </div>
                                </form>
                            </Accordion>
                            <Accordion title="Sladjana Miljanovic">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Username:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Hours per week:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Email:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Status:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        defaultChecked={true}
                                                        className="radio-input"
                                                        name="radio-group-status"
                                                    />
                                                    <label
                                                        htmlFor="rdo1"
                                                        className="radio-label"
                                                    >
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Active
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group-status"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Inactive
                                                    </label>
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Role:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        defaultChecked={true}
                                                        className="radio-input"
                                                        name="radio-group-role"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Admin
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group-role"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Worker
                                                    </label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div className="btn-wrap">
                                        <button
                                            type="submit"
                                            className="btn btn--green"
                                        >
                                            <span>Save changes</span>
                                        </button>
                                        <button
                                            type="button"
                                            className="btn btn--red"
                                        >
                                            <span>Delete</span>
                                        </button>
                                        <button
                                            type="button"
                                            className="btn btn--orange"
                                        >
                                            <span>Change passwword</span>
                                        </button>
                                    </div>
                                </form>
                            </Accordion>
                        </div>
                        <Pagination />
                    </section>
                </div>
            </div>
            <Footer />
        </>
    );
};
