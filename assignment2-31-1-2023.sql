use employee
drop table loan_details
create table loan_details
(
branch_id int,
loan_amount bigint,
customer_number varchar(20) foreign key references customer_master(customer_number))


drop table customer_master
create table customer_master
(
customer_number varchar(20) primary key,
FIRSTNAME varchar(50),
middlename varchar(50),
lastname varchar(50),
customer_city varchar(30),
customer_contact_no bigint,
occupation varchar(50),
customer_date_of_birth date)


create table account_master
(
account_number bigint primary key,
customer_number varchar(20) foreign key references customer_master(customer_number),
branch_id int foreign key references branch_master(branch_id),
opening_balence int,
account_opening_date date,
account_type varchar(25),
aaccount_status varchar(30)
)

create table branch_master
(branch_id int primary key,
branch_name varchar(50),
branch_city varchar(30)
)

create table transaction_details
(
transaction_number int primary key,
account_number bigint foreign key references account_master(account_number),
date_of_transaction date,
medium_of_transaction varchar(50),
transaction_type varchar(50),
transaction_amount int)