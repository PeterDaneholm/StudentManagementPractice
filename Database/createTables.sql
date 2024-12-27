\c StudentManagement;
   
\i createTypes.sql
   
CREATE TABLE Student (
    studentId UUID PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    currentClasses UUID[] REFERENCES Course(courseId),
    passedClasses UUID[] REFERENCES Course(courseId),
    grades UUID[] REFERENCES Grade(gradeId),
    year YEAR NOT NULL,
    sports UUID[] REFERENCES Sport(sportId),
    extraCorricularActivities UUID[] REFERENCES ExtraActivity(activityId)
);

CREATE TABLE Course (
    courseId UUID PRIMARY KEY,
    courseName VARCHAR(255) NOT NULL,
    professor UUID REFERENCES Professor(profId),
    maxAttendees SMALLINT NOT NULL DEFAULT 30 CHECK (maxAttendess =< 30),
    attendingStudents UUID[] REFERENCES Student(studentId),
    waitList UUID[] REFERENCES Student(studentId),
    final DATE NOT NULL,
    midTerm DATE NOT NULL,
    semester SEMESTER NOT NULL,
    year YEAR NOT NULL,
    examAttempt SMALLINT DEFAULT 0
);

CREATE TABLE Grade (
    gradeId UUID PRIMARY KEY,
    courseID UUID REFERENCES Course(courseId),
    studentID UUID REFERENCES Student(studentId),
    grade GRADEVALUE,
    isPassed BOOL DEFAULT FALSE
);

CREATE TABLE Professor (
    profId UUID PRIMARY KEY,
    profName VARCHAR(255) NOT NULL,
    courses UUID[] REFERENCES Course(courseId)
);

CREATE TABLE Sport (
    sportId UUID PRIMARY KEY,
    sportName VARCHAR(255) NOT NULL
);

CREATE TABLE ExtraActivity (
    activityId UUID PRIMARY KEY,
    activityName VARCHAR(255) NOT NULL
);