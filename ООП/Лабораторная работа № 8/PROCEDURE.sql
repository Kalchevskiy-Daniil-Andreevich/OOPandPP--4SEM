CREATE PROCEDURE SelectBooks @ID_BOOK int, @DATE_EDITION smallint 
AS SELECT * FROM BOOKS INNER JOIN EDITION
ON BOOKS.ID_BOOK = EDITION.ID_BOOK INNER JOIN AUTHORS
ON BOOKS.ID_AUTHOR = AUTHORS.ID_AUTHOR
WHERE BOOKS.ID_BOOK = @ID_BOOK AND EDITION.DATE_EDITION = @DATE_EDITION







--CREATE PROCEDURE SelectPerson @Age int, @Country nvarchar(20) AS SELECT * FROM PERSON JOIN ADDRESS ON PERSON.id_address = ADDRESS.id_address JOIN PASSPORT ON PERSON.id_passport = PASSPORT.id_passport
--WHERE PERSON.age >= @Age AND ADDRESS.country = @Country