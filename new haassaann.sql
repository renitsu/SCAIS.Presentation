IF OBJECT_ID('dbo.Prerequisites', 'U') IS NULL
BEGIN
    CREATE TABLE Prerequisites (
        PrerequisiteId INT IDENTITY(1,1) PRIMARY KEY,
        CourseId INT NOT NULL,
        RequiredCourseId INT NOT NULL
    );
END;

-- sample data (adjust CourseId numbers if needed)
INSERT INTO Prerequisites (CourseId, RequiredCourseId) VALUES
(2, 1),  -- ITCS201 requires ITCS101
(3, 1),  -- ITCS205 requires ITCS101
(3, 2),  -- ITCS205 requires ITCS201
(4, 2),  -- Web Tech requires OOP
(5, 3);  -- Mobile Dev requires DB
