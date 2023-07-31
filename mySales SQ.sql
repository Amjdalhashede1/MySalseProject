Create table login_program(
    username varchar(35) primary key ,
    password varchar(35) not null,
    is_active bit,
    emp_no  int  references employee(emp_no)
);
Create table settings_bg(
    r int,
    g int,
    b int
);

Create table category(
category_no int primary key,
category_name varchar(70),
category_detail varchar(max)
);

Create table employee(
    emp_no int primary key,
    emp_name varchar(150) not null,
    gender varchar(10) not null,
    address varchar(200) not null,
    id_number varchar(25) unique,
    birth_date date ,
    Qualification varchar(250),
    emp_state varchar(100)
);



create table employee_phone (
    emp_no int,
    emp_phone varchar(60) ,
    primary key (emp_no ,emp_phone),
    foreign key (emp_no) references employee(emp_no)
);

create table employee_image (
    emp_no int primary key,
    emp_image image,
    foreign key (emp_no) references employee(emp_no)
);

Create table Unit(
    unit_no int primary key,
    unit_name varchar(150),
    unit_details varchar(max)
);

Create table Company(
    company_no int primary key identity(1,1),
    company_code varchar(50),
    company_name varhcar(150),
    address varchar(200),
    date_created date,
    other_details varchar(max)
);

Create view employee_not_user
as
select e.emp_no,e.emp_name from employee e
left join login_program l
on e.emp_no = l.emp_no
where e.emp_no not in  (select emp_no from login_program)

Create view login_program_data
as
select e.emp_no,e.emp_name,l.username,l.password,l.is_active
from employee,login_program l
where e.emp_no = l.emp_no;

create table program_actions
(
   action_num int primary key identity(1,1),
   username varchar(35),
   action_date date,
   action_time time(7),
   form_name varchar(255),
   operation_name varchar(255),
   action_data varchar(max),
   foreign key(username) references login_program(username)
);
