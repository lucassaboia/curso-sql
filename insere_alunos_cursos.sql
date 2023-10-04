SELECT NEWID()
SELECT * FROM [Course]
SELECT * FROM [StudentCourse]
INSERT INTO [Student]
VALUES(
'cf32c35e-6a25-451b-bf75-c0745964006b',
'André Baltieri',
'hello@balta.io',
'12345678901',
'12345678',
NULL,
GETDATE()
)

INSERT INTO [StudentCourse]
VALUES (
'5f5a33f8-4ff3-7e10-cc6e-3fa000000000',
'cf32c35e-6a25-451b-bf75-c0745964006b',
50,
0,
'2020-01-13 12:35:54',
GETDATE() 
)