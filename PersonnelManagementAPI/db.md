create table user_record
(
    id uuid default uuid_generate_v4() not null
    primary key,
    muserid uuid,
    mdate timestamp default CURRENT_TIMESTAMP,
    isdeleted boolean default false,
    description text,
    name text not null,
    lastname text not null,
    idnumber text,
    username text not null
    constraint user_record_uniqe_name unique,
    isactive boolean default true,
    details jsonb,
    addressdetail jsonb,
    countryid uuid,
    phonenumber jsonb,
    foundationid uuid,
    foundationsubid uuid,
    permissions jsonb,
    roles jsonb,
    birthdate date,
    image text,
    passwordhash text,
    applang text default 'tr'::text,
    email text,
    typeid uuid,
    languageids jsonb,
    nationalityids jsonb,
    docinfos jsonb,
    ismanager boolean default false
);

alter table user_record
owner to postgres;
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE invoice
(
id uuid default uuid_generate_v4() not null primary key,
muserid uuid,
mdate timestamp default CURRENT_TIMESTAMP,
isdeleted boolean default false,
description text,

    invoicenumber text,
    invoicedate date,
    amount float4

);

ALTER TABLE invoice
OWNER TO postgres;
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------