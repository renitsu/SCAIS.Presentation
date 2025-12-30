CREATE TABLE Courses (
    CourseId INT IDENTITY(1,1) PRIMARY KEY,
    Code NVARCHAR(20) NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    Credits INT NOT NULL,
    IsCore BIT NOT NULL
);
INSERT INTO Courses (Code, Title, Credits, IsCore) VALUES
('ITCS101', 'Introduction to Computing', 3, 1),
('ITCS201', 'Object Oriented Programming', 3, 1),
('ITCS205', 'Database Systems', 3, 1),
('ITCS210', 'Web Technologies', 3, 0),
('ITCS310', 'Mobile Application Development', 3, 0);
