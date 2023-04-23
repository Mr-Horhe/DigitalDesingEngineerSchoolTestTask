--alter table employee add constraint fk1 FOREIGN KEY(DEPARTMENT_ID) REFERENCES Department(ID);
--alter table employee add constraint fk2 FOREIGN KEY(CHIEF_ID) REFERENCES EMPLOYEE(ID);

--SELECT EMPLOYEE.NAME from EMPLOYEE
--where salary >= all(select max(salary) from Employee);

--SELECT Department.NAME FROM EMPLOYEE inner join Department on employee.DEPARTMENT_ID=department.ID
--group by DEPARTMENT.NAME
--having sum(salary) >= ALL(select sum(salary) from employee group by DEPARTMENT_ID);

--select EMPLOYEE.NAME from EMPLOYEE
--where name like 'Ð%í';

--WITH t AS (
--   SELECT 1 AS lvl, e.Chief_Id, e.id
--   FROM Employee e
--   WHERE Chief_Id IS NULL
--   UNION ALL
--   SELECT lvl + 1, emp.Chief_Id, emp.id
--   FROM Employee emp
--   JOIN t
--     ON emp.Chief_Id = t.id
--) Select max(lvl) as 'Max depth' from t;

