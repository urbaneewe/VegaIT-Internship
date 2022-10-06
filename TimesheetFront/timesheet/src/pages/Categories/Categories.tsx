import React from 'react';
import { Accordion } from '../../shared/components/Accordion';
import { Alphabet } from '../../shared/components/Alphabet';
import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';
import { Modal } from '../../shared/components/Modal';
import { Pagination } from '../../shared/components/Pagination';

export const Categories = () => {
    const [isModalOpen, setIsModalOpen] = React.useState(false);

    return (
        <>
            <Header />
            <div className="container">
                {isModalOpen && (
                    <Modal
                        title="Create new category"
                        onClose={() => setIsModalOpen(false)}
                    >
                        <form className="info" action="javascript:;">
                            <ul className="info__form">
                                <li className="info__list">
                                    <label className="info__label">
                                        Category name:
                                    </label>
                                    <input type="text" className="in-text" />
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
                            <h2 className="main-content__title">Category</h2>
                            <div className="table-navigation">
                                <a
                                    href="javascript:;"
                                    className="table-navigation__create btn-modal"
                                    onClick={() => {
                                        setIsModalOpen(true);
                                    }}
                                >
                                    <span>Create new category</span>
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
                            <Accordion title="Category 1">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Category name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
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
                            <Accordion title="Category 2">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Category name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
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
                            <Accordion title="Category 3">
                                <form
                                    className="accordion__content"
                                    action="javascript:;"
                                >
                                    <div className="info">
                                        <div className="info__form">
                                            <ul className="info__wrapper">
                                                <li className="info__list">
                                                    <label className="info__label">
                                                        Category name:
                                                    </label>
                                                    <input
                                                        type="text"
                                                        className="in-text"
                                                    />
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
