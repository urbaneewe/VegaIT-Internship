import React from 'react';

export const Accordion = ({
    children,
    title,
}: {
    children: React.ReactElement;
    title: string;
}) => {
    const [isOpen, setIsOpen] = React.useState(false);

    return (
        <div className="accordion" onClick={() => setIsOpen(!isOpen)}>
            <div className="accordion__intro">
                <h4 className="accordion__title">{title}</h4>
            </div>
            {isOpen && children}
        </div>
    );
};
