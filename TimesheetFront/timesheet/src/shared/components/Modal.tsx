import React from 'react';

export const Modal = ({
    children,
    title,
    onClose,
}: {
    children: React.ReactElement;
    title: string;
    onClose: () => void;
}) => {
    return (
        <div className="modal">
            <div className="modal__content">
                <h2 className="heading">{title}</h2>
                <a href="#" className="modal__close" onClick={onClose}>
                    <span className="modal__icon"></span>
                </a>
                {children}
            </div>
        </div>
    );
};
