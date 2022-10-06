import React from 'react';
import { Accordion } from '../../shared/components/Accordion';
import { Alphabet } from '../../shared/components/Alphabet';
import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';
import { Modal } from '../../shared/components/Modal';
import { Pagination } from '../../shared/components/Pagination';

export const Projects = () => {
    const [isModalOpen, setIsModalOpen] = React.useState(false);

    return (
        <>
            <div className="container">
                <Header />
                {isModalOpen && (
                    <Modal
                        title="Create new project"
                        onClose={() => setIsModalOpen(false)}
                    >
                        <form className="info" action="javascript:;">
                            <ul className="info__form">
                                <li className="info__list">
                                    <label className="info__label">
                                        Project name:
                                    </label>
                                    <input type="text" className="in-text" />
                                </li>
                                <li className="info__list">
                                    <label className="report__label">
                                        Description:
                                    </label>
                                    <input type="text" className="in-text" />
                                </li>
                                <li className="info__list">
                                    <label className="report__label">
                                        Client:
                                    </label>
                                    <select className="info__select">
                                        <option value="">All</option>
                                    </select>
                                </li>
                                <li className="info__list">
                                    <label className="report__label">
                                        Lead:
                                    </label>
                                    <select className="info__select">
                                        <option value="">All</option>
                                    </select>
                                </li>
                            </ul>
                            <div className="btn-wrap">
                                <button
                                    type="submit"
                                    className="btn btn--green"
                                >
                                    <span>Save changes</span>
                                </button>
                                <button type="button" className="btn btn--red">
                                    <span>Delete</span>
                                </button>
                            </div>
                        </form>
                    </Modal>
                )}
                <div className="wrapper">
                    <section className="content">
                        <div className="main-content">
                            <h2 className="main-content__title">Project</h2>
                            <div className="table-navigation">
                                <a
                                    href="javascript:;"
                                    className="table-navigation__create btn-modal"
                                    onClick={() => {
                                        setIsModalOpen(true);
                                    }}
                                >
                                    <span>Create new project</span>
                                </a>
                                <form
                                    className="table-navigation__input-container"
                                    action="javascript:;"
                                >
                                    <input
                                        type="text"
                                        className="table-navigation__search"
                                    />
                                    <button
                                        type="submit"
                                        className="icon__search"
                                    ></button>
                                </form>
                            </div>
                            <Alphabet />
                            <Accordion title="Project 1">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Project name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Description:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Client:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Lead:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Status:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        id="rdo1"
                                                        className="radio-input"
                                                        name="radio-group"
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
                                                        checked
                                                        className="radio-input"
                                                        name="radio-group"
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
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group"
                                                    />
                                                    <label
                                                        htmlFor="rdo1"
                                                        className="radio-label"
                                                    >
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Archive
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
                                    </div>
                                </form>
                            </Accordion>
                            <Accordion title="Project 2">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Project name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Description:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Client:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Lead:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Status:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group"
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
                                                        checked
                                                        className="radio-input"
                                                        name="radio-group"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Inactive
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Archive
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
                                    </div>
                                </form>
                            </Accordion>
                            <Accordion title="Project 3">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Project name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Description:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Client:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list">
                                                    <label className="report__label">
                                                        Lead:
                                                    </label>
                                                    <select className="info__select">
                                                        <option value="">
                                                            All
                                                        </option>
                                                    </select>
                                                </li>
                                                <li className="info__list-title">
                                                    <h4 className="radio-button__title">
                                                        Status:
                                                    </h4>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group"
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
                                                        checked
                                                        className="radio-input"
                                                        name="radio-group"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Inactive
                                                    </label>
                                                </li>
                                                <li className="info__list-radio-button">
                                                    <input
                                                        type="radio"
                                                        className="radio-input"
                                                        name="radio-group"
                                                    />
                                                    <label className="radio-label">
                                                        {' '}
                                                        <span className="radio-border"></span>
                                                        Archive
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
