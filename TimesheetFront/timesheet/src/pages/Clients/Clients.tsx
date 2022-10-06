import { useEffect, useState } from 'react';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { Accordion } from '../../shared/components/Accordion';
import { Alphabet } from '../../shared/components/Alphabet';
import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';
import { Modal } from '../../shared/components/Modal';
import { Pagination } from '../../shared/components/Pagination';
import { ClientData } from './ClientData';
import { ClientForm } from './ClientForm';
import { getClientsRequested } from './clientReducer';

export const Clients = () => {
    const clients = useAppSelector((state) => state.clients.clients);
    const dispatch = useAppDispatch();
    const [isModalOpen, setIsModalOpen] = useState(false);

    useEffect(() => {
        dispatch(getClientsRequested());
    }, []);

    return (
        <>
            <div className="container">
                <Header />
                {isModalOpen && (
                    <Modal
                        title="Create new client"
                        onClose={() => setIsModalOpen(false)}
                    >
                        <ClientForm />
                    </Modal>
                )}
                <div className="wrapper">
                    <section className="content">
                        <div className="main-content">
                            <h2 className="main-content__title">Clients</h2>
                            <div className="table-navigation">
                                <a
                                    href="javascript:;"
                                    className="table-navigation__create btn-modal"
                                    onClick={() => {
                                        setIsModalOpen(true);
                                    }}
                                >
                                    <span>Create new client</span>
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

                            {clients.map((client) => (
                                <Accordion title={client.name} key={client.id}>
                                    <ClientData />
                                </Accordion>
                            ))}
                        </div>
                        <Pagination />
                    </section>
                </div>
            </div>

            <Footer />
        </>
    );
};
