import { Footer } from '../../shared/components/Footer';
import { Header } from '../../shared/components/Header';

export const ForgotPassword = () => {
    return (
        <>
            <div className="container">
                <Header />
                <div className="initial-form">
                    <div className="wrapper">
                        <div className="main-content">
                            <h1 className="main-content__title">
                                Forgot password
                            </h1>
                            <form className="info" action="javacript:;">
                                <ul className="info__form">
                                    <li className="info__list">
                                        <label className="info__label">
                                            Email:
                                        </label>
                                        <input
                                            type="text"
                                            className="in-text"
                                        />
                                    </li>
                                </ul>
                                <div className="btn-wrap">
                                    <button
                                        type="submit"
                                        className="btn btn--orange"
                                    >
                                        <span>Reset password</span>
                                    </button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <Footer />
        </>
    );
};
