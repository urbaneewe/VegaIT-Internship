import { useEffect, useState } from 'react';
import { useAppDispatch, useAppSelector } from '../../redux/hooks';
import { Address } from './address';
import { Client } from './client';
import { addClientRequested } from './clientReducer';
import { Country } from './country';
import { getCountriesRequested } from './countryReducer';

export const ClientForm = () => {
    const [country, setCountry] = useState(new Country('', ''));
    const [address, setAddress] = useState(new Address('', '', '', 0, country));
    const [client, setClient] = useState(new Client('', '', address));
    const dispatch = useAppDispatch();

    const countries = useAppSelector((state) => state.countries.countries);

    useEffect(() => {
        dispatch(getCountriesRequested());
    }, []);

    const handleAddClient = () => {
        dispatch(addClientRequested());
    };
    // useEffect(() => {
    //     dispatch(addClientRequested());
    // }, []);

    return (
        <form className="info" action="javascript:;">
            <ul className="info__form">
                <li className="info__list">
                    <label className="info__label">Client name:</label>
                    <input
                        type="text"
                        className="in-text"
                        onChange={(el) => {
                            client.name = el.target.value;
                        }}
                        required
                    />
                </li>
                <li className="info__list">
                    <label className="report__label">Address:</label>
                    <input
                        type="text"
                        className="in-text"
                        onChange={(el) => {
                            client.address.name = el.target.value;
                        }}
                        required
                    />
                </li>
                <li className="info__list">
                    <label className="report__label">City:</label>
                    <input
                        type="text"
                        className="in-text"
                        onChange={(el) => {
                            client.address.city = el.target.value;
                        }}
                        required
                    />
                </li>
                <li className="info__list">
                    <label className="report__label">Zip/Postal code:</label>
                    <input
                        type="text"
                        className="in-text"
                        onChange={(el) => {
                            client.address.postalCode = el.target.valueAsNumber;
                        }}
                        required
                    />
                </li>
                <li className="info__list">
                    <label className="report__label">Country:</label>
                    <select
                        className="info__select"
                        onChange={(el) => {
                            client.address.country.name = el.target.value;
                        }}
                    >
                        {countries.map((value) => (
                            <option key={value.id} value={value.name}>
                                {value.name}
                            </option>
                        ))}
                    </select>
                </li>
            </ul>
            <div className="btn-wrap">
                <button
                    type="submit"
                    className="btn btn--green"
                    onClick={handleAddClient}
                >
                    <span>Save changes</span>
                </button>
                <button type="button" className="btn btn--red">
                    <span>Delete</span>
                </button>
            </div>
        </form>
    );
};
