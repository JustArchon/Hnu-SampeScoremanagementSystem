using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Person
    {
        public string name;
        public string phonenumber;
        public string email;
        public string depart; // 소속 학과,부서
    }
    class Faculty : Person
    {
        public string businessnumber;
        private int salay;
        public int Salay
        {
            get { return salay; }
            set {
                if (value > 0)
                {
                    salay = value;
                }
                else
                {
                    Console.WriteLine("올바른 값을 입력하여 주십시오.");
                    salay = 0;
                }
            }
        }
        public int dataenty;
        public string job;
    }
    class Professor: Faculty, IPrint
    {
        public string rank;
        public List<Subject> subjects = new List<Subject> { };
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("교수명: " + name);
            Console.WriteLine("직급: " + rank);
            Console.WriteLine("학과: " + depart);
            Console.WriteLine("교수 사번: " + businessnumber);
            Console.WriteLine("교수 전화번호: " + phonenumber);
            Console.WriteLine("교수 이메일: " + email);
            Console.WriteLine("월급여: " + Salay);
            Console.WriteLine("입사일: " + dataenty);
            Console.WriteLine("강의 과목:");
            foreach (var item in subjects)
            {
                Console.WriteLine(item.subname);
            }
        }
    }
    class Staff : Faculty, IPrint
    {
        public string rank;
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("직원명: " + name);
            Console.WriteLine("직급: " + rank);
            Console.WriteLine("소속 학과 혹은 부서: " + depart);
            Console.WriteLine("사번: " + businessnumber);
            Console.WriteLine("전화번호: " + phonenumber);
            Console.WriteLine("이메일: " + email);
            Console.WriteLine("월급여: " + Salay);
            Console.WriteLine("입사일: " + dataenty);
        }
    }
    class Assistant : Faculty, IPrint
    {
        public List<Subject> Assubjects = new List<Subject> { };
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("조교명: " + name);
            Console.WriteLine("학과: " + depart);
            Console.WriteLine("조교 사번: " + businessnumber);
            Console.WriteLine("조교 전화번호: " + phonenumber);
            Console.WriteLine("조교 이메일: " + email);
            Console.WriteLine("월급여: " + Salay);
            Console.WriteLine("입사일: " + dataenty);
            Console.WriteLine("배당 과목:");
            foreach (var item in Assubjects)
            {
                Console.WriteLine(item.subname);
            }
        }
    }
    interface IPrint
    {
        void Pirnt_All_Moment();

    }
    class Student : Person, IPrint
    {
        public string StudentID;
        private int grade;
        public int Grade
        {
            get { return grade; }
            set {
                if( value >= 1 && value <= 4)
                {
                    grade = value;
                }
                else
                {
                    Console.WriteLine("올바른 학년을 입력하여 주십시오.");
                    grade = 0;
                }
            }
        }
        public List<Scholarship> Scholarships = new List<Scholarship> { };
        public List<SubjectEnd> SubejctEndlist = new List<SubjectEnd> { };
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("학생명: " + name);
            Console.WriteLine("학년: " + grade);
            Console.WriteLine("학과: " + depart);
            Console.WriteLine("학번: " + StudentID);
            Console.WriteLine("전화번호: " + phonenumber);
            Console.WriteLine("이메일: " + email);
            Console.WriteLine("수혜 장학금 내역:");
            foreach (var item in Scholarships)
            {
                Console.WriteLine(item.title + " : " + item.Money + "만원");
            }
            Console.WriteLine("수강 완료과목:");
            Console.WriteLine("1학기:");
            foreach (var item in SubejctEndlist)
            {
                if(item.term == 1)
                {
                    Console.WriteLine(item.subname);
                }
                
            }
            Console.WriteLine("2학기:");
            foreach (var item in SubejctEndlist)
            {
                if (item.term == 2)
                {
                    Console.WriteLine(item.subname);
                }

            }
        }
    }

    class Scholarship
    {
        public string title;
        private int money;
        public int Money
        {
            get { return money; }
            set {
                if( value > 0)
                {
                    money = value;
                }
                else
                {
                    Console.WriteLine("올바른 값을 입력하여 주십시오.");
                    money = 0;
                }
            }
        }
    }
    class Division
    {

    }
    class Team: Division, IPrint
    {
        public string teamID;
        public string teamname;
        public string teamadress;
        public string teamphonenumber;
        public string teamemail;
        public string teamhomepage;
        public List<Staff> StaffList = new List<Staff> { };
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("부서명: " + teamname);
            Console.WriteLine("부서 주소: " + teamadress);
            Console.WriteLine("부서 전화번호: " + teamphonenumber);
            Console.WriteLine("소속 직원:");
            foreach (var item in StaffList)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("이메일: " + teamemail);
            Console.WriteLine("부서홈페이지: " + teamhomepage);
        }
    }
    class Department: Division, IPrint
    {
        public string departID;
        public string departname;
        public string departadress;
        public string departphonenumber;
        public List<Assistant> AssistantList = new List<Assistant> { };
        public List<Staff> StaffList = new List<Staff> { };
        public List<Professor> ProfessorList = new List<Professor> { };
        public List<Student> StudentList = new List<Student> { };
        public string headofdepart;
        public string departemail;
        public string departhomepage;
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("학과명: " + departname);
            Console.WriteLine("학과 주소: " + departadress);
            Console.WriteLine("학과 전화번호: " + departphonenumber);
            Console.WriteLine("소속 조교:");
            foreach(var item in AssistantList)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("소속 교수:");
            foreach (var item in ProfessorList)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("소속 학생:");
            foreach (var item in StudentList)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("학과장: " + headofdepart);
            Console.WriteLine("이메일: " + departemail);
            Console.WriteLine("학과홈페이지: " + departhomepage);
        }
    }
    class Subject : IPrint
    {
        public string subname;
        public string subdepart;
        public string subProfesser;
        public string subAssistant;
        public string lectureroomnumber;
        public int targetgrade;
        public int term;
        public virtual void Pirnt_All_Moment()
        {
            Console.WriteLine("교과명: " + subname);
            Console.WriteLine("학과명: " + subdepart);
            Console.WriteLine("담당 교수: " + subProfesser);
            Console.WriteLine("담당 조교: " + subAssistant);
            Console.WriteLine("강의실: " + lectureroomnumber);
            Console.WriteLine("대상 학년: " + targetgrade);
            Console.WriteLine("학기: " + term);
        }
    }
    class USStudent : Subject, IPrint
    {
        public string studentname;
        public int studentgrade;
        public string offerStuID;
        public bool ratingend;
        public override void Pirnt_All_Moment()
        {
            Console.WriteLine("신청 학생: " + studentname);
            Console.WriteLine("신청 학생 학년: " + studentgrade);
            Console.WriteLine("신청 학생 학번: " + offerStuID);
            Console.WriteLine("교과명: " + subname);
            Console.WriteLine("학과명: " + subdepart);
            Console.WriteLine("담당 교수: " + subProfesser);
            Console.WriteLine("강의실: " + lectureroomnumber);
            Console.WriteLine("대상 학년: " + targetgrade);
            Console.WriteLine("학기: " + term);
        }
    }
    interface ISubjectessentials
    {
        string Getrecordal();
        double Getrecordnumber();
        void Setrecord();

    }
    struct SubjectEnd : ISubjectessentials, IPrint
    {
        public string subname;
        public string subdepart;
        public string subProfesser;
        public string studentname;
        public string StudentID;
        public int studentgrade;
        public int term;
        private string recordal;
        private double recordnumber;
        public bool ratingend;
        public string Getrecordal()
        {
            return this.recordal;
        }
        public double Getrecordnumber()
        {
            return this.recordnumber;
        }
        public void Setrecord(double value)
        {
            if(value >= 0 && value <= 4.5)
            {
                this.recordnumber = value;
            }
            else
            {
                Console.WriteLine("0 ~ 4.5 내 점수를 입력하여 주십시오.");
                this.recordnumber = 0;
            }
            
        }
        public void Setrecord(string value)
        {
            if(value == "A+" || value == "A" || value == "A-" || value == "B+" || value == "B" || value == "B-" || value == "C+" || value == "C" || value == "C-" || value == "D+" || value == "D" || value == "D-" || value == "F")
            {
                this.recordal = value;
            }
            else
            {
                Console.WriteLine("A+ ~ F 등급을 입력하여 주십시오.");
            }
            
        }
        public void Pirnt_All_Moment()
        {
            Console.WriteLine("이름: " + studentname);
            Console.WriteLine("학년: " + studentgrade);
            Console.WriteLine("학번: " + StudentID);
            Console.WriteLine("교과명: " + subname);
            Console.WriteLine("학과명: " + subdepart);
            Console.WriteLine("담당 교수: " + subProfesser);
            Console.WriteLine("학기: " + term);
            Console.WriteLine("등급: " + Getrecordal());
            Console.WriteLine("성적점수: " + Getrecordnumber());
        }

        public void Setrecord()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        
        public static string globalbusnumber;
        public static string globalstunumber;
        public static int globalterm;
        static void Main(string[] args)
        {
            string modename = null;
            string mode = null;
            string idnumber;
            string inputstring;
            string inputstring2;
            string inputstring3;
            double Avgscore;
            double Count;
            bool login;
            bool check;
            bool check2;
            bool check3;
            string menu;
            List<Division> PartmentList = new List<Division>()
            {
                new Department(){ departID = "HannamComputer", departname = "컴퓨터공학과", departadress = "(34430) 대전광역시 대덕구 한남로 70 한남대학교 공과대학 212호 컴퓨터공학과", departphonenumber = "042-629-7544", headofdepart = "이만희", departemail = "hnu7544@hnu.kr", departhomepage = "http://ce.hannam.ac.kr/main/"},
                new Department(){ departID = "HannamICT", departname = "정보통신공학과", departadress = "(34430) 대전광역시 대덕구 한남로 70 한남대학교 공과대학 417호 정보통신공학과", departphonenumber = "042-629-7567", headofdepart = "윤영선", departemail = "ice@hnu.kr", departhomepage = "http://ice.hannam.ac.kr/main/"},
                new Team(){ teamID = "ScholarTeam", teamname = "장학부", teamadress = "(34430) 대전광역시 대덕구 한남로 70 한남대학교 학생회관 1층 학생복지처 장학팀", teamemail = "sch@hnu.kr", teamhomepage  = "http://janghak.hannam.ac.kr/main/", teamphonenumber = "042-629-7260"}
            };
            List<Person> SchoolHumanList = new List<Person>
            {
                new Professor() { name = "이만희", businessnumber = "203245", dataenty = 0402, depart="컴퓨터공학과", email = "manheelee@hnu.kr", phonenumber="042-629-7623", job = "교수" ,rank="교수(학과장)",Salay=10000 },
                new Professor() { name = "이강수", businessnumber = "201141", dataenty = 0502, depart="컴퓨터공학과", email = "gslee@hnu.kr", phonenumber="042-629-7549", job = "교수", rank="교수",Salay=20000 },
                new Professor() { name = "이극", businessnumber = "203241", dataenty = 0602, depart="컴퓨터공학과", email = "leegeuk@hnu.kr", phonenumber="042-629-7550", job = "교수", rank="교수",Salay=30000 },
                new Professor() { name = "최의인", businessnumber = "206241", dataenty = 0702, depart="컴퓨터공학과", email = "eichoi@hnu.kr", phonenumber="042-629-7981", job = "교수", rank="교수",Salay=24000 },
                new Professor() { name = "안기영", businessnumber = "201121", dataenty = 0122, depart="컴퓨터공학과", email = "kyagrd@gmail.com", phonenumber="042-629-7497", job = "교수", rank="조교수",Salay=12000 },
                new Professor() { name = "장준혁", businessnumber = "202341", dataenty = 0222, depart="컴퓨터공학과", email = "jhjang@hnu.kr", phonenumber="042-629-7463", job = "교수", rank="조교수",Salay=11000 },
                new Professor() { name = "장효경", businessnumber = "203242", dataenty = 0422, depart="컴퓨터공학과", email = "chantellejang@hotmail.com", phonenumber="042-629-7471", job = "교수", rank="조교수",Salay=14000 },

                new Professor() { name = "윤영선", businessnumber = "213542", dataenty = 0412, depart="정보통신공학과", email = "ysyun@hnu.kr", phonenumber="042-629-7569", job = "교수", rank="교수",Salay=13000 },
                new Professor() { name = "박성우", businessnumber = "215522", dataenty = 0402, depart="정보통신공학과", email = "swpark@hnu.kr", phonenumber="042-629-7398", job = "교수", rank="교수",Salay=12000 },
                new Professor() { name = "은성배", businessnumber = "213512", dataenty = 0412, depart="정보통신공학과", email = "sbeun@hnu.kr", phonenumber="042-629-7928", job = "교수", rank="교수",Salay=14000 },
                new Professor() { name = "류성한", businessnumber = "213572", dataenty = 0412, depart="정보통신공학과", email = "ilikeit@hnu.kr", phonenumber="042-629-8531", job = "교수", rank="교수",Salay=16000 },
                new Professor() { name = "차신", businessnumber = "217582", dataenty = 0412, depart="정보통신공학과", email = "scha@hnu.kr", phonenumber="042-629-7289", job = "교수", rank="부교수",Salay=18000 },
                new Professor() { name = "유동호", businessnumber = "217219", dataenty = 0412, depart="정보통신공학과", email = "dongho.you@hnu.kr", phonenumber="042-629-8532", job = "교수", rank="조교수",Salay=13000 },
                new Professor() { name = "정광현", businessnumber = "218239", dataenty = 0412, depart="정보통신공학과", email = "gh.jeong@hnu.kr", phonenumber="042-629-8521", job = "교수", rank="조교수",Salay=14000 },

                new Assistant() { name = "윤유빈", businessnumber = "102243", dataenty = 0213, depart ="컴퓨터공학과", email = "ubin@hnu.kr", phonenumber = "042-629-7544", Salay = 10133, job = "조교"},
                new Assistant() { name = "류하은", businessnumber = "101243", dataenty = 0223, depart ="정보통신공학과", email = "heun@hnu.kr", phonenumber = "042-629-7567", Salay = 10113, job = "조교"},
                new Assistant() { name = "한찬희", businessnumber = "103343", dataenty = 0323, depart ="컴퓨터공학과", email = "chan@hnu.kr", phonenumber = "010-3321-7567", Salay = 10123, job = "조교"},
 
                new Staff() { name = "장남준", businessnumber = "108343", dataenty = 0323, depart ="장학팀", email = "jang@hnu.kr", phonenumber = "010-6307-3773", Salay = 10123, job = "직원", rank = "정직원"},

                new Student() { name = "홍길동", Grade= 2, depart = "컴퓨터공학과", email = "honggildong@hnu.kr", phonenumber = "010-3775-2324", StudentID = "1244223" },
                new Student() { name = "김길동", Grade= 3, depart = "컴퓨터공학과", email = "kimggildong@hnu.kr", phonenumber = "010-4534-7882", StudentID = "1241123" },
                new Student() { name = "홍순희", Grade= 1, depart = "컴퓨터공학과", email = "honsun@hnu.kr", phonenumber = "010-5483-3048", StudentID = "1211323" },
                new Student() { name = "김진구", Grade= 3, depart = "컴퓨터공학과", email = "jingu@hnu.kr", phonenumber = "010-7451-0100", StudentID = "1141123" },
                new Student() { name = "김구몬", Grade= 4, depart = "컴퓨터공학과", email = "gumon@hnu.kr", phonenumber = "010-0713-0812", StudentID = "1215123" },
                new Student() { name = "임경혜", Grade= 1, depart = "컴퓨터공학과", email = "limgyeung@hnu.kr", phonenumber = "010-8235-4800", StudentID = "1267123" },
                new Student() { name = "장승혁", Grade= 3, depart = "컴퓨터공학과", email = "jangseung@hnu.kr", phonenumber = "010-3771-2324", StudentID = "1285123" },
                new Student() { name = "남희철", Grade= 2, depart = "컴퓨터공학과", email = "namheui@hnu.kr", phonenumber = "010-3711-3711", StudentID = "1221123" },
                new Student() { name = "임병일", Grade= 4, depart = "컴퓨터공학과", email = "limbyeoung@hnu.kr", phonenumber = "010-1287-1782", StudentID = "1233123" },
                new Student() { name = "이진구", Grade= 3, depart = "컴퓨터공학과", email = "leejingu@hnu.kr", phonenumber = "010-5340-7525", StudentID = "115123" },

                new Student() { name = "설신영", Grade= 1, depart = "정보통신공학과", email = "seolsinyoung@hnu.kr", phonenumber = "010-5340-7525", StudentID = "182892" },
                new Student() { name = "윤정수", Grade= 2, depart = "정보통신공학과", email = "younjungsu@hnu.kr", phonenumber = "010-3541-5747", StudentID = "1241177" },
                new Student() { name = "백남혁", Grade= 3, depart = "정보통신공학과", email = "backnamhyuck@hnu.kr", phonenumber = "010-3562-0862", StudentID = "1228123" },
                new Student() { name = "남궁태우", Grade= 1, depart = "정보통신공학과", email = "namgung@hnu.kr", phonenumber = "010-6816-8211", StudentID = "1161123" },
                new Student() { name = "송원옥", Grade= 2, depart = "정보통신공학과", email = "songwon@hnu.kr", phonenumber = "010-2001-4027", StudentID = "1248823" },
                new Student() { name = "오은아", Grade= 3, depart = "정보통신공학과", email = "oona@hnu.kr", phonenumber = "010-4466-2852", StudentID = "1242023" },
                new Student() { name = "손범수", Grade= 4, depart = "정보통신공학과", email = "sonbusu@hnu.kr", phonenumber = "010-6134-0626", StudentID = "1249023" },
                new Student() { name = "한준우", Grade= 2, depart = "정보통신공학과", email = "hanjun@hnu.kr", phonenumber = "010-6237-3560", StudentID = "1247623" },
                new Student() { name = "봉연웅", Grade= 3, depart = "정보통신공학과", email = "bong@hnu.kr", phonenumber = "010-3374-7333", StudentID = "1241723" },
                new Student() { name = "양상윤", Grade= 1, depart = "정보통신공학과", email = "yangsang@hnu.kr", phonenumber = "010-2775-1886", StudentID = "1244523" }

            };

            List<Subject> SubjectList = new List<Subject>()
            {
                new Subject(){subname = "이산구조", subdepart = "컴퓨터공학과", subProfesser = "이강수", lectureroomnumber = "9503", targetgrade =  1, term = 1},
                new Subject(){subname = ".NET 프로그래밍", subdepart = "컴퓨터공학과", subProfesser = "이만희", subAssistant = "한찬희",lectureroomnumber = "9303", targetgrade =  3, term = 2},
                new Subject(){subname = "객체지향프로그래밍", subdepart = "컴퓨터공학과", subProfesser = "안기영", lectureroomnumber = "9203", targetgrade =  2, term = 2},
                new Subject(){subname = "자료구조", subdepart = "컴퓨터공학과", subProfesser = "최의인", lectureroomnumber = "9403", targetgrade =  1, term = 2},
                new Subject(){subname = "모바일프로그래밍", subdepart = "컴퓨터공학과", subProfesser = "이극", lectureroomnumber = "9505", targetgrade =  3, term = 2},
                new Subject(){subname = "컴퓨터개론", subdepart = "컴퓨터공학과", subProfesser = "장준혁", lectureroomnumber = "9402", targetgrade =  1, term = 2},
                new Subject(){subname = "컴퓨터네트워크", subdepart = "컴퓨터공학과", subProfesser = "장효경", lectureroomnumber = "9305", targetgrade =  3, term = 2},
                new Subject(){subname = "알고리즘", subdepart = "컴퓨터공학과", subProfesser = "장준혁", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                
                new Subject(){subname = "데이터구조", subdepart = "정보통신공학과", subProfesser = "차신", lectureroomnumber = "9411", targetgrade =  2, term = 1},
                new Subject(){subname = "DB프로그래밍", subdepart = "정보통신공학과", subProfesser = "류성한", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                new Subject(){subname = "데이터통신", subdepart = "정보통신공학과", subProfesser = "은성배", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                new Subject(){subname = "센서회로", subdepart = "정보통신공학과", subProfesser = "윤영선", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                new Subject(){subname = "인공지능", subdepart = "정보통신공학과", subProfesser = "박성우", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                new Subject(){subname = "전파공학", subdepart = "정보통신공학과", subProfesser = "유동호", lectureroomnumber = "9421", targetgrade =  2, term = 1},
                new Subject(){subname = "자바프로그래밍", subdepart = "정보통신공학과", subProfesser = "정광현", lectureroomnumber = "9421", targetgrade =  2, term = 1}
            };
            List<USStudent> EnrolmentList = new List<USStudent> // 학생 수강신청데이터 모음 불러올시 여기를 foreach한다. 확정시 내부 struct list로들어감
            {

            };
            //추가 데이터

            //소속 데이터 새로고침
            foreach (var item in PartmentList)
            {
                foreach (var item2 in SchoolHumanList)
                {
                    if (item is Department)
                    {
                        if (item2 is Professor)
                        {
                            if ((item as Department).departname == item2.depart)
                            {
                                (item as Department).ProfessorList.Add(item2 as Professor);
                            }
                        }
                    } 
                }
                foreach (var item2 in SchoolHumanList)
                {
                    if (item is Department)
                    {
                        if (item2 is Assistant)
                        {
                            if ((item as Department).departname == item2.depart)
                            {
                                (item as Department).AssistantList.Add(item2 as Assistant);
                            }
                        }
                    }
                }
                foreach (var item2 in SchoolHumanList)
                {
                    if (item is Department)
                    {
                        if (item2 is Student)
                        {
                            if ((item as Department).departname == item2.depart)
                            {
                                (item as Department).StudentList.Add(item2 as Student);
                            }
                        }
                    }
                }
                foreach (var item2 in SchoolHumanList)
                {
                    if (item is Team)
                    {
                        if (item2 is Staff)
                        {
                            if ((item as Team).teamname == item2.depart)
                            {
                                (item as Team).StaffList.Add(item2 as Staff);
                            }
                        }
                    }
                }
            }
            
            foreach (var item in SubjectList)
            {
                foreach(var item2 in SchoolHumanList)
                {
                    if(item2 is Professor)
                    {
                        if(item.subProfesser == item2.name)
                        {
                            (item2 as Professor).subjects.Add(item);
                        }
                    }
                }
                foreach (var item2 in SchoolHumanList)
                {
                    if (item2 is Assistant)
                    {
                        if (item.subAssistant == item2.name)
                        {
                            (item2 as Assistant).Assubjects.Add(item);
                        }
                    }
                }
            }
            // 수강생 자동랜덤 신청코드
            Console.WriteLine("초기데이터 생성중입니다. 잠시만 기다려주십시오...");
            SubjectList.Sort((x1, x2) => x1.subdepart.CompareTo(x2.subdepart)); // 학과별정렬
            int counter = 0;
            int startnum = 0;
            int ICTnum = 0;
            int Comnum = 0;
            foreach(var item in SubjectList) // 아쉽게도 초기데이터에서 학과를 추가하면 이곳을 계속추가해줘야합니다.. 방법을 아시면 미래의 누군가가 픽스해주길..
            {
                if(item.subdepart == "정보통신공학과")
                {
                    counter++;
                    ICTnum = counter;
                }
                if(item.subdepart == "컴퓨터공학과")
                {
                    counter++;
                    Comnum = counter;
                }
            }
            List<int> sign = new List<int> { };
            List<int> sign2 = new List<int> { };
            string[] SignD = new string[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-" };
            double[] SignN = new double[] { 4.5, 4.3, 4.0, 3.5, 3.3, 3.0, 2.5, 2.3, 2.0, 1.5, 1.3, 1 };
            int signN;
            foreach(var item in SchoolHumanList) { 
                if (item is Student)
                {
                    (item as Student).Scholarships.Add(new Scholarship() { title = "가족 우대 장학금", Money = 100 });
                    if((item as Student).depart == "컴퓨터공학과")
                    {
                        for (int j = ICTnum; j < Comnum; j++)
                        {
                            do
                            {
                                signN = new Random().Next(ICTnum, Comnum);
                            }
                            while (sign.Contains(signN));
                            sign.Add(signN);
                        }
                    }
                    else if ((item as Student).depart == "정보통신공학과")
                    {
                        for (int j = startnum; j < ICTnum; j++)
                        {
                            do
                            {
                                signN = new Random().Next(startnum, ICTnum);
                            }
                            while (sign.Contains(signN));
                            sign.Add(signN);
                        }
                    }
                        for (int x = 0; x < 3; x++)
                    {
                        do
                        {
                            signN = new Random().Next(0, 12);
                        }
                        while (sign2.Contains(signN));
                        sign2.Add(signN);
                    }

                    for (int z = 0; z < 3; z++)
                    {
                        SubjectEnd SE = new SubjectEnd
                        {
                            subname = SubjectList[sign[z]].subname,
                            studentgrade = (item as Student).Grade,
                            subProfesser = SubjectList[sign[z]].subProfesser,
                            studentname = item.name,
                            subdepart = SubjectList[sign[z]].subdepart,
                            StudentID = (item as Student).StudentID,
                            term = SubjectList[sign[z]].term,
                            ratingend = true
                        };
                        SE.Setrecord(SignD[sign2[z]]);
                        SE.Setrecord(SignN[sign2[z]]);
                        SubjectEnd SE2 = SE;
                        (item as Student).SubejctEndlist.Add(SE2);
                    }
                    for (int y = 2; y < 6; y++)
                    {
                        EnrolmentList.Add(new USStudent() { subname = SubjectList[sign[y]].subname, subProfesser = SubjectList[sign[y]].subProfesser, subdepart = SubjectList[sign[y]].subdepart, subAssistant = SubjectList[sign[y]].subAssistant, term = SubjectList[sign[y]].term, lectureroomnumber = SubjectList[sign[y]].lectureroomnumber, studentgrade = (item as Student).Grade, studentname = (item as Student).name, targetgrade = SubjectList[sign[y]].targetgrade, offerStuID = (item as Student).StudentID, ratingend = false });
                    }
                    sign.Clear();
                    sign2.Clear();
                }
            }

            DateTime nowDate = DateTime.Now;
            if(nowDate.Month >= 1 && nowDate.Month <= 8)
            {
                globalterm = 1;
            }
            else if (nowDate.Month >= 9 && nowDate.Month <= 12)
            {
                globalterm = 2;
            }
            login = false;
            while (true)
            {
                check = false;
                Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha");
                Console.WriteLine("학번 혹은 사번을 입력하여 주십시오. 관리자로 로그인시 관리자 아이디를 입력하여주십시오.");
                Console.WriteLine("종료를 원하시면 Quit 를 입력하여 주십시오.");
                Console.Write("입력: ");
                idnumber = Console.ReadLine();
                if (idnumber == "Hannamadmin")
                {
                    mode = "Hannamadmin";
                    check = true;
                    login = true;
                }
                else if (idnumber == "Quit")
                {
                    break;
                }
                else
                {
                    foreach (var item in PartmentList) // foreach(var item in PartmentList)
                    {
                        if (item is Department)
                        {
                            if ((item as Department).departID == idnumber)
                            {
                                mode = "Departmentadmin";
                                modename = (item as Department).departname;
                                check = true;
                                login = true;
                            }
                        }
                    }
                    foreach (var item in PartmentList) // foreach(var item in PartmentList)
                    {
                        if (item is Team)
                        {
                            if ((item as Team).teamID == idnumber)
                            {
                                mode = "Teamadmin";
                                modename = (item as Team).teamname;
                                check = true;
                                login = true;
                            }
                        }
                    }
                    foreach (var item in SchoolHumanList)
                    {
                        if (item is Professor)
                        {
                            if ((item as Professor).businessnumber == idnumber)
                            {
                                mode = "Professor";
                                modename = item.name;
                                globalbusnumber = (item as Professor).businessnumber;
                                check = true;
                                login = true;
                            }
                        }

                    }
                    foreach (var item in SchoolHumanList)
                    {
                        if (item is Assistant)
                        {
                            if ((item as Assistant).businessnumber == idnumber)
                            {
                                mode = "Assistant";
                                modename = item.name;
                                globalbusnumber = (item as Assistant).businessnumber;
                                check = true;
                                login = true;
                            }
                        }

                    }
                    foreach (var item in SchoolHumanList)
                    {
                        if (item is Staff)
                        {
                            if ((item as Staff).businessnumber == idnumber)
                            {
                                mode = "Staff";
                                modename = item.name;
                                globalbusnumber = (item as Staff).businessnumber;
                                check = true;
                                login = true;
                            }
                        }

                    }
                    foreach (var item in SchoolHumanList)
                    {
                        if (item is Student)
                        {
                            if ((item as Student).StudentID == idnumber)
                            {
                                mode = "Student";
                                modename = item.name;
                                globalstunumber = (item as Student).StudentID;
                                check = true;
                                login = true;
                            }
                        }
                    }
                    // 학과어드민, 교수, 학생들의 아이디확인
                }
                if(check == false)
                {
                    Console.WriteLine("존재하지 않는 사번,학번 혹은 아이디입니다.");
                    Console.ReadKey();
                    Console.Clear();
                }
            
            while (login == true)
            {
                if(mode == "Hannamadmin")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha 한남대학교 Admin모드");
                        Console.WriteLine("1. 학과 및 부서 관리, 2. 교직원 관리, 3. 학생 관리, 4. 교과목 관리, 5. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                do
                                {
                                    check = false;
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 학과 및 부서 관리, 한남대학교 Admin모드");
                                    Console.WriteLine("현재 등록된 학과 및 부서:");
                                    foreach(var item in PartmentList)
                                    {
                                        if(item is Department)
                                        {
                                            Console.WriteLine((item as Department).departname);
                                        }
                                        if(item is Team)
                                        {
                                            Console.WriteLine((item as Team).teamname);
                                        }
                                    }
                                    Console.WriteLine("1. 학과 및 부서 추가, 2. 학과 및 부서 변경, 3. 학과 및 부서 정보 검색 4. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                        Console.WriteLine("추가하고자 하는 유형이 학과인지 부서인지 입력하시오.");
                                        inputstring = Console.ReadLine();
                                        if(inputstring == "학과")
                                        {
                                            Department De = new Department();
                                            Console.WriteLine("학과 이름을 입력하여 주십시오.");
                                            De.departname = Console.ReadLine();
                                            Console.WriteLine("학과 admin 아이디를 입력하여 주십시오.");
                                            De.departID = Console.ReadLine();
                                            Console.WriteLine("학과주소를 입력하여 주십시오.");
                                            De.departadress = Console.ReadLine();
                                            Console.WriteLine("학과 전화번호를 입력하여 주십시오.");
                                            De.departphonenumber = Console.ReadLine();
                                            Console.WriteLine("학과장을 입력하여주십시오.");
                                            De.headofdepart = Console.ReadLine();
                                            Console.WriteLine("학과 홈페이지 주소를 입력하여주십시오.");
                                            De.departhomepage = Console.ReadLine();
                                            Console.WriteLine("학과 이메일 주소를 입력하여주십시오.");
                                            De.departemail = Console.ReadLine();
                                            PartmentList.Add(De);
                                            Console.WriteLine("학과가 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                        else if(inputstring == "부서")
                                        {
                                            Team Te = new Team();
                                            Console.WriteLine("부서 이름을 입력하여 주십시오.");
                                            Te.teamname = Console.ReadLine();
                                            Console.WriteLine("부서 admin 아이디를 입력하여 주십시오.");
                                            Te.teamID = Console.ReadLine();
                                            Console.WriteLine("부서주소를 입력하여 주십시오.");
                                            Te.teamadress = Console.ReadLine();
                                            Console.WriteLine("부서 전화번호를 입력하여 주십시오.");
                                            Te.teamphonenumber = Console.ReadLine();
                                            Console.WriteLine("부서 홈페이지 주소를 입력하여주십시오.");
                                            Te.teamhomepage = Console.ReadLine();
                                            Console.WriteLine("부서 이메일 주소를 입력하여주십시오.");
                                            Te.teamemail = Console.ReadLine();
                                            PartmentList.Add(Te);
                                            Console.WriteLine("부서가 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                        else 
                                        {
                                            Console.WriteLine("정상적인 유형이 아닙니다. 다시 입력하여 주십시오.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (menu == "2")
                                    {
                                        Console.WriteLine("변경하고자 하는 학과 및 부서 이름을 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in PartmentList)
                                        {
                                            if(item is Department) 
                                            {
                                                if ((item as Department).departname == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경할 학과 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departname = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과 아이디를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departID = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과 주소를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departadress = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departphonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과장을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).headofdepart = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과홈페이지를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departhomepage = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학과 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Department).departemail = inputstring;
                                                    }
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경된 학과 정보를 확인하십시오.");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (item is Team)
                                            {
                                                if ((item as Team).teamname == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경할 부서 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamname = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 부서 아이디를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamID = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 부서 주소를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamadress = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 부서 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamphonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 부서홈페이지를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamhomepage = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 부서 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Team).teamemail = inputstring;
                                                    }
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경된 부서 정보를 확인하십시오.");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                        if(check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 학과 및 부서입니다.");
                                            Console.ReadKey();
                                        }

                                    }
                                    else if (menu == "3")
                                    {
                                        Console.WriteLine("검색하고자 하는 학과 및 부서 이름을 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in PartmentList)
                                        {
                                            if(item is Department)
                                            {
                                                if ((item as Department).departname == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.ReadKey();
                                                }
                                            }
                                            if(item is Team)
                                            {
                                                if ((item as Team).teamname == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.ReadKey();
                                                }
                                            }
                                            
                                        }
                                    }
                                } while (menu != "4");
                                menu = "0";
                                break;
                            case "2":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 교직원 관리, 한남대학교 Admin모드");
                                    Console.WriteLine("1. 교직원 추가, 2. 교직원 변경, 3. 교직원 삭제 4. 교직원 정보확인 5. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                        check = false;
                                        Console.WriteLine("추가할 교직원 직책을 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        if (inputstring == "교수")
                                        {
                                            Professor Mem = new Professor();
                                            Console.WriteLine("교수 이름을 입력하여 주십시오.");
                                            Mem.name = Console.ReadLine();
                                            Console.WriteLine("교수 사번을 입력하여 주십시오.");
                                            Mem.businessnumber = Console.ReadLine();
                                            Console.WriteLine("교수 이메일을 입력하여 주십시오.");
                                            Mem.email = Console.ReadLine();
                                            Console.WriteLine("교수 전화번호를 입력하여 주십시오.");
                                            Mem.phonenumber = Console.ReadLine();
                                            Console.WriteLine("현재 등록된 학과:");
                                            foreach (var item in PartmentList)
                                            {
                                                if (item is Department)
                                                {
                                                    Console.WriteLine((item as Department).departname);
                                                }
                                            }
                                            while (Mem.depart == null)
                                            {
                                                Console.WriteLine("교수 소속 학과를 입력하여주십시오.");
                                                inputstring = Console.ReadLine();
                                                foreach (var item in PartmentList)
                                                {
                                                    if(item is Department)
                                                    {
                                                        if ((item as Department).departname == inputstring)
                                                        {
                                                            Mem.depart = inputstring;
                                                            check = true;
                                                        }
                                                    }
                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("존재하지 않는 학과입니다. 다시입력하여 주십시오.");
                                                }
                                            }
                                            while(Mem.Salay == 0)
                                                {
                                                    Console.WriteLine("교수 월급여를 입력하여주십시오.");
                                                    Mem.Salay = int.Parse(Console.ReadLine());
                                                }
                                            Console.WriteLine("교수 입사일을 입력하여주십시오.");
                                            Mem.dataenty = int.Parse(Console.ReadLine());
                                            Console.WriteLine("교수 직급을 입력하여주십시오.");
                                            (Mem as Professor).rank = Console.ReadLine();
                                            SchoolHumanList.Add(Mem);
                                            foreach (var item in PartmentList)
                                            {
                                                if(item is Department)
                                                {
                                                    if ((item as Department).departname == Mem.depart)
                                                    {
                                                        (item as Department).ProfessorList.Add(Mem);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("교수가 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                        else if (inputstring == "직원")
                                        {
                                            Staff Mem = new Staff();
                                            Console.WriteLine("직원 이름을 입력하여 주십시오.");
                                            Mem.name = Console.ReadLine();
                                            Console.WriteLine("직원 사번을 입력하여 주십시오.");
                                            Mem.businessnumber = Console.ReadLine();
                                            Console.WriteLine("직원 이메일을 입력하여 주십시오.");
                                            Mem.email = Console.ReadLine();
                                            Console.WriteLine("직원 전화번호를 입력하여 주십시오.");
                                            Mem.phonenumber = Console.ReadLine();
                                            Console.WriteLine("현재 등록된 학과 및 부서:");
                                            foreach (var item in PartmentList)
                                            {
                                                if (item is Department)
                                                {
                                                    Console.WriteLine((item as Department).departname);
                                                }
                                                if (item is Team)
                                                {
                                                    Console.WriteLine((item as Team).teamname);
                                                }
                                            }
                                            while (Mem.depart == null)
                                            {
                                                Console.WriteLine("직원 소속 학과 혹은 부서를 입력하여주십시오.");
                                                inputstring = Console.ReadLine();
                                                foreach (var item in PartmentList)
                                                {
                                                    if(item is Department)
                                                    {
                                                        if ((item as Department).departname == inputstring)
                                                        {
                                                            Mem.depart = inputstring;
                                                            check = true;
                                                        }
                                                    }
                                                    if(item is Team)
                                                    {
                                                        if ((item as Team).teamname == inputstring)
                                                        {
                                                            Mem.depart = inputstring;
                                                            check = true;
                                                        }
                                                    }
                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("존재하지 않는 학과 혹은 부서입니다. 다시입력하여 주십시오.");
                                                }
                                            }
                                                while (Mem.Salay == 0)
                                                {
                                                    Console.WriteLine("직원 월급여를 입력하여주십시오.");
                                                    Mem.Salay = int.Parse(Console.ReadLine());
                                                }
                                            Console.WriteLine("직원 입사일을 입력하여주십시오.");
                                            Mem.dataenty = int.Parse(Console.ReadLine());
                                            Console.WriteLine("직원 직급을 입력하여주십시오.");
                                            (Mem as Staff).rank = Console.ReadLine();
                                            SchoolHumanList.Add(Mem);
                                            foreach (var item in PartmentList)
                                            {
                                                if (item is Department)
                                                {
                                                    if ((item as Department).departname == Mem.depart)
                                                    {
                                                        (item as Department).StaffList.Add(Mem);
                                                    }
                                                }
                                                if (item is Team)
                                                {
                                                    if ((item as Team).teamname == Mem.depart)
                                                    {
                                                        (item as Team).StaffList.Add(Mem);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("직원이 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                        else if (inputstring == "조교")
                                        {
                                            Assistant Mem = new Assistant();
                                            Console.WriteLine("조교 이름을 입력하여 주십시오.");
                                            Mem.name = Console.ReadLine();
                                            Console.WriteLine("조교 사번을 입력하여 주십시오.");
                                            Mem.businessnumber = Console.ReadLine();
                                            Console.WriteLine("조교 이메일을 입력하여 주십시오.");
                                            Mem.email = Console.ReadLine();
                                            Console.WriteLine("조교 전화번호를 입력하여 주십시오.");
                                            Mem.phonenumber = Console.ReadLine();
                                            Console.WriteLine("현재 등록된 학과 및 부서:");
                                            foreach (var item in PartmentList)
                                            {
                                                if (item is Department)
                                                {
                                                    Console.WriteLine((item as Department).departname);
                                                }
                                                if (item is Team)
                                                {
                                                    Console.WriteLine((item as Team).teamname);
                                                }
                                            }
                                            while (Mem.depart == null)
                                            {
                                                Console.WriteLine("조교 소속 학과 혹은 부서를 입력하여주십시오.");
                                                inputstring = Console.ReadLine();
                                                foreach (var item in PartmentList)
                                                {
                                                    if (item is Department)
                                                    {
                                                        if ((item as Department).departname == inputstring)
                                                        {
                                                            Mem.depart = inputstring;
                                                            check = true;
                                                        }
                                                    }
                                                    if (item is Team)
                                                    {
                                                        if ((item as Team).teamname == inputstring)
                                                        {
                                                            Mem.depart = inputstring;
                                                            check = true;
                                                        }
                                                    }
                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("존재하지 않는 학과 혹은 부서입니다. 다시입력하여 주십시오.");
                                                }
                                            }
                                                while (Mem.Salay == 0)
                                                {
                                                    Console.WriteLine("조교 월급여를 입력하여주십시오.");
                                                    Mem.Salay = int.Parse(Console.ReadLine());
                                                }
                                            Console.WriteLine("조교 입사일을 입력하여주십시오.");
                                            Mem.dataenty = int.Parse(Console.ReadLine());
                                            SchoolHumanList.Add(Mem);
                                            foreach (var item in PartmentList)
                                            {
                                                if(item is Department)
                                                {
                                                    if ((item as Department).departname == Mem.depart)
                                                    {
                                                        (item as Department).AssistantList.Add(Mem);
                                                    }
                                                }
                                            }
                                            foreach (var item in PartmentList)
                                            {
                                                if (item is Department)
                                                {
                                                    if ((item as Department).departname == Mem.depart)
                                                    {
                                                        (item as Department).AssistantList.Add(Mem);
                                                    }
                                                }
                                            }
                                            Console.WriteLine("조교가 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("정상적인 직책이 아닙니다. 다시 입력하여 주십시오.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (menu == "2")
                                    {
                                        check = false;
                                        check2 = false;
                                        Console.WriteLine("변경하고자 하는 교직원 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                            if (item is Professor)
                                            {
                                                if ((item as Professor).name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Professor).businessnumber == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    check = true;
                                                    Console.WriteLine("변경할 교수 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.name = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 교수 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Professor).businessnumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 교수 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.phonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 교수 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.email = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 교수 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        foreach (var item2 in PartmentList)
                                                        {
                                                            if (item2 is Department)
                                                            {
                                                                if ((item2 as Department).departname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (check2 == false && inputstring != "")
                                                    {
                                                        Console.WriteLine("존재하지 않는 학과입니다.");
                                                    }
                                                        Console.WriteLine("변경할 교수 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            (item as Professor).Salay = int.Parse(inputstring);
                                                        }
                                                        while ((item as Professor).Salay == 0)
                                                        {
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Professor).Salay = int.Parse(inputstring);
                                                            }
                                                        }
                                                        Console.WriteLine("변경할 교수 직급을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Professor).rank = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 교수 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Professor).dataenty = int.Parse(inputstring);
                                                    }
                                                        (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경된 교수 정보를 확인하십시오.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Assistant)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    check = true;
                                                    Console.WriteLine("변경할 조교 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.name = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 조교 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Assistant).businessnumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 조교 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.phonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 조교 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.email = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 조교 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        foreach (var item2 in PartmentList)
                                                        {
                                                            if (item2 is Department)
                                                            {
                                                                if ((item2 as Department).departname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                            if (item2 is Team)
                                                            {
                                                                if ((item2 as Team).teamname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (check2 == false && inputstring != "")
                                                    {
                                                        Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                    }
                                                        Console.WriteLine("변경할 조교 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            (item as Assistant).Salay = int.Parse(inputstring);
                                                        }
                                                        while ((item as Assistant).Salay == 0)
                                                        {
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).Salay = int.Parse(inputstring);
                                                            }
                                                        }
                                                    Console.WriteLine("변경할 조교 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Assistant).dataenty = int.Parse(inputstring);
                                                    }
                                                        (item as IPrint).Pirnt_All_Moment();

                                                    Console.WriteLine("변경된 조교 정보를 확인하십시오.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Staff)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    check = true;
                                                    Console.WriteLine("변경할 직원 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.name = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 직원 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Staff).businessnumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 직원 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.phonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 직원 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.email = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 직원 학과 혹은 부서를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과, 부서일시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        foreach (var item2 in PartmentList)
                                                        {
                                                            if (item2 is Department)
                                                            {
                                                                if ((item2 as Department).departname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                            if (item2 is Team)
                                                            {
                                                                if ((item2 as Team).teamname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (check2 == false && inputstring != "")
                                                    {
                                                        Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                    }
                                                        Console.WriteLine("변경할 직원 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            (item as Staff).Salay = int.Parse(inputstring);
                                                        }
                                                        while ((item as Staff).Salay == 0)
                                                        {
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).Salay = int.Parse(inputstring);
                                                            }
                                                        }
                                                    Console.WriteLine("변경할 직원 직급을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Staff).rank = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 직원 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Staff).dataenty = int.Parse(inputstring);
                                                    }
                                                        (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경된 직원 정보를 확인하십시오.");
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교직원입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (menu == "3") // 기능추가, 과목, 학과정보 추가삭제
                                    {
                                        check = false;
                                        Console.WriteLine("삭제하고자 하는 교직원 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        for (int i = SchoolHumanList.Count - 1; i >= 0; i--)
                                        {
                                            if (SchoolHumanList[i] is Professor)
                                            {
                                                if (SchoolHumanList[i].name == inputstring || SchoolHumanList[i].phonenumber == inputstring || SchoolHumanList[i].email == inputstring || (SchoolHumanList[i] as Professor).businessnumber == inputstring)
                                                {
                                                    for (int j = SubjectList.Count - 1; j >= 0; j--)
                                                    {
                                                        if (SubjectList[j].subProfesser == SchoolHumanList[i].name)
                                                        {
                                                            SubjectList[j].subProfesser = null;
                                                        }
                                                    }
                                                    SchoolHumanList.RemoveAt(i);
                                                    for (int z = PartmentList.Count - 1; z >= 0; z--)
                                                    {
                                                        if(PartmentList[z] is Department)
                                                        {
                                                            for (int j = (PartmentList[z] as Department).ProfessorList.Count - 1; j >= 0; j--)
                                                            {
                                                                if ((PartmentList[z] as Department).ProfessorList[j].name == inputstring || (PartmentList[z] as Department).ProfessorList[j].phonenumber == inputstring || (PartmentList[z] as Department).ProfessorList[j].email == inputstring || (PartmentList[z] as Department).ProfessorList[j].businessnumber == inputstring)
                                                                {
                                                                    (PartmentList[z] as Department).ProfessorList.RemoveAt(j);
                                                                    Console.WriteLine("성공적으로 교수 정보를 삭제하였습니다. 학과 내의 일부 정보는 직접 수정해야 할수 있으니 확인바랍니다.");
                                                                    check = true;
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            else if (SchoolHumanList[i] is Staff)
                                            {
                                                if (SchoolHumanList[i].name == inputstring || SchoolHumanList[i].phonenumber == inputstring || SchoolHumanList[i].email == inputstring || (SchoolHumanList[i] as Staff).businessnumber == inputstring)
                                                {
                                                    SchoolHumanList.RemoveAt(i);
                                                    for (int z = PartmentList.Count - 1; z >= 0; z--)
                                                    {
                                                        if (PartmentList[z] is Department)
                                                        {
                                                            for (int j = (PartmentList[z] as Department).StaffList.Count - 1; j >= 0; j--)
                                                            {
                                                                if ((PartmentList[z] as Department).StaffList[j].name == inputstring || (PartmentList[z] as Department).StaffList[j].phonenumber == inputstring || (PartmentList[z] as Department).StaffList[j].email == inputstring || (PartmentList[z] as Department).StaffList[j].businessnumber == inputstring)
                                                                {
                                                                    (PartmentList[z] as Department).StaffList.RemoveAt(j);
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    for (int z = PartmentList.Count - 1; z >= 0; z--)
                                                    {
                                                        if (PartmentList[z] is Team)
                                                        {
                                                            for (int j = (PartmentList[z] as Team).StaffList.Count - 1; j >= 0; j--)
                                                            {
                                                                if ((PartmentList[z] as Team).StaffList[j].name == inputstring || (PartmentList[z] as Team).StaffList[j].phonenumber == inputstring || (PartmentList[z] as Team).StaffList[j].email == inputstring || (PartmentList[z] as Team).StaffList[j].businessnumber == inputstring)
                                                                {
                                                                    (PartmentList[z] as Team).StaffList.RemoveAt(j);
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                    Console.WriteLine("성공적으로 직원 정보를 삭제하였습니다.");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (SchoolHumanList[i] is Assistant)
                                            {
                                                if (SchoolHumanList[i].name == inputstring || SchoolHumanList[i].phonenumber == inputstring || SchoolHumanList[i].email == inputstring || (SchoolHumanList[i] as Assistant).businessnumber == inputstring)
                                                {
                                                    for (int l = SubjectList.Count - 1; l >= 0; l--)
                                                    {
                                                        if (SubjectList[l].subAssistant == SchoolHumanList[i].name)
                                                        {
                                                            SubjectList[l].subAssistant = null;
                                                        }
                                                    }
                                                    SchoolHumanList.RemoveAt(i);
                                                    for (int z = PartmentList.Count - 1; z >= 0; z--)
                                                    {
                                                        if (PartmentList[z] is Department)
                                                        {
                                                            for (int j = (PartmentList[z] as Department).AssistantList.Count - 1; j >= 0; j--)
                                                            {
                                                                if ((PartmentList[z] as Department).AssistantList[j].name == inputstring || (PartmentList[z] as Department).AssistantList[j].phonenumber == inputstring || (PartmentList[z] as Department).AssistantList[j].email == inputstring || (PartmentList[z] as Department).AssistantList[j].businessnumber == inputstring)
                                                                {
                                                                    (PartmentList[z] as Department).AssistantList.RemoveAt(j);
                                                                    Console.WriteLine("성공적으로 조교 정보를 삭제하였습니다.");
                                                                    check = true;
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }   
                                                    }
                                                }
                                            }
                                         }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교직원입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                        
                                    else if (menu == "4")
                                    {
                                        check = false;
                                        Console.WriteLine("검색하고자 하는 교직원 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                            if (item is Professor)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Professor).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Assistant)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Staff)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교직원입니다.");
                                            Console.ReadKey();
                                        }
                                        
                                    }
                                } while (menu != "5");
                                menu = "0";
                                break;
                            case "3":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 학생 관리, 한남대학교 Admin모드");
                                    Console.WriteLine("1. 학생 추가, 2. 학생 변경, 3. 학생 삭제, 4. 학생 정보검색, 5. 장학금 내역 입력, 6. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                        check = false;
                                        Student St = new Student();
                                        Console.WriteLine("학생 이름을 입력하여 주십시오.");
                                        St.name = Console.ReadLine();
                                        Console.WriteLine("학생 전화번호를 입력하여 주십시오.");
                                        St.phonenumber = Console.ReadLine();
                                        Console.WriteLine("학생 이메일을 입력하여 주십시오.");
                                        St.email = Console.ReadLine();
                                        Console.WriteLine("현재 등록된 학과:");
                                        foreach (var item in PartmentList)
                                        {
                                            if (item is Department)
                                            {
                                                Console.WriteLine((item as Department).departname);
                                            }
                                        }
                                        while (St.depart == null)
                                        {
                                            Console.WriteLine("학생 학과를 입력하여주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in PartmentList)
                                            {
                                                if(item is Department)
                                                {
                                                    if ((item as Department).departname == inputstring)
                                                    {
                                                        St.depart = inputstring;
                                                        check = true;
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 학과입니다. 다시입력하여 주십시오.");
                                            }
                                        }
                                        Console.WriteLine("학번을 입력하여 주십시오.");
                                        St.StudentID = Console.ReadLine();
                                            while(St.Grade == 0)
                                            {
                                                Console.WriteLine("학년을 입력하여주십시오.");
                                                St.Grade = int.Parse(Console.ReadLine());
                                            }
                                        SchoolHumanList.Add(St);
                                        foreach (var item in PartmentList)
                                        {
                                            if( item is Department)
                                            {
                                                if ((item as Department).departname == St.depart)
                                                {
                                                    (item as Department).StudentList.Add(St);
                                                }
                                            }
                                        }
                                        Console.WriteLine("학생이 정상적으로 추가되었습니다.");
                                        Console.ReadKey();
                                    }
                                    else if (menu == "2")
                                    {
                                        check = false;
                                        check2 = false;
                                        Console.WriteLine("변경하고자 하는 학생 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                            if (item is Student)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Student).StudentID == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    check = true;
                                                    Console.WriteLine("변경할 학생 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.name = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학생 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.phonenumber = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        item.email = inputstring;
                                                    }
                                                    Console.WriteLine("변경할 학번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        (item as Student).StudentID = inputstring;
                                                    }
                                                    while((item as Student).Grade == 0)
                                                        {
                                                            Console.WriteLine("변경할 학년을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Student).Grade = int.Parse(inputstring);
                                                            }
                                                        }
                                                    Console.WriteLine("변경할 학생 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                    inputstring = Console.ReadLine();
                                                    if (inputstring != "")
                                                    {
                                                        foreach (var item2 in PartmentList)
                                                        {
                                                            if(item2 is Department)
                                                            {
                                                                if ((item2 as Department).departname == inputstring)
                                                                {
                                                                    check2 = true;
                                                                    item.depart = inputstring;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    if (check2 == false && inputstring != "")
                                                    {
                                                        Console.WriteLine("존재하지 않는 학과입니다.");
                                                    }
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("변경된 학생 정보를 확인하십시오.");
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                            
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 학생입니다.");
                                            Console.ReadKey();
                                        }

                                    }
                                    else if (menu == "3")
                                    {
                                        string delStudent;
                                        check = false;
                                        Console.WriteLine("삭제하고자 하는 학생 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        for (int i = SchoolHumanList.Count - 1; i >= 0; i--)
                                        {
                                            if(SchoolHumanList[i] is Student)
                                            {
                                                if (SchoolHumanList[i].name == inputstring || SchoolHumanList[i].phonenumber == inputstring || SchoolHumanList[i].email == inputstring || (SchoolHumanList[i] as Student).StudentID == inputstring)
                                                {
                                                    check = true;
                                                    delStudent = (SchoolHumanList[i] as Student).StudentID;
                                                    SchoolHumanList.RemoveAt(i);

                                                    for (int j = EnrolmentList.Count - 1; j >= 0; j--)
                                                    {
                                                        if (EnrolmentList[j].offerStuID == delStudent)
                                                        {
                                                            EnrolmentList.RemoveAt(j);
                                                        }
                                                    }
                                                }
                                                for (int z = PartmentList.Count - 1; z >= 0; z--)
                                                {
                                                    if(PartmentList[z] is Department)
                                                    {
                                                        for (int l = (PartmentList[z] as Department).StudentList.Count - 1; l >= 0; l--)
                                                        {
                                                                if ((PartmentList[z] as Department).StudentList[l].name == inputstring || (PartmentList[z] as Department).StudentList[l].phonenumber == inputstring || (PartmentList[z] as Department).StudentList[l].email == inputstring || (PartmentList[z] as Department).StudentList[l].StudentID == inputstring)
                                                                {
                                                                    (PartmentList[z] as Department).StudentList.RemoveAt(l);
                                                                }
                                                        }
                                                    }
                                                }
                                            }
                                                   
                                        }
                                        
                                        if(check == true)
                                        {
                                                Console.WriteLine("성공적으로 학생 정보를 삭제하였습니다.");
                                                Console.ReadKey();
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 학생입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (menu == "4")
                                    {
                                        check = false;
                                        Console.WriteLine("검색하고자 하는 학생 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                            if(item is Student)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Student).StudentID == inputstring || item.depart == inputstring)
                                                {
                                                    check = true;
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.ReadKey();
                                                }
                                            }
                                            
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 학생입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if(menu == "5")
                                        {
                                            check = false;
                                            Console.WriteLine("장학금 수혜 내역을 입력하고자 하는 학생 학번을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if ((item as Student).StudentID == inputstring)
                                                    {
                                                        check = true;
                                                        Scholarship Sc = new Scholarship();
                                                        Console.WriteLine("수혜받은 장학금 이름을 입력하여 주십시오.");
                                                        Sc.title = Console.ReadLine();
                                                        while (Sc.Money == 0)
                                                        {
                                                            Console.WriteLine("수혜받은 장학금 금액을 입력하여 주십시오. (만원 단위)");
                                                            Sc.Money = int.Parse(Console.ReadLine());
                                                        }
                                                        (item as Student).Scholarships.Add(Sc);
                                                        Console.WriteLine("정상적으로 장학금내역이 추가되었습니다.");
                                                        Console.ReadKey();
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지않는 학생입니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                } while (menu != "6");
                                menu = "0";
                                break;
                            case "4":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 교과목 관리, 한남대학교 Admin모드");
                                    Console.WriteLine("1. 과목 추가, 2. 과목 제거 , 3. 과목 검색 4. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                        check = false;
                                        Subject Sb = new Subject();
                                        Console.WriteLine("과목 이름을 입력하여 주십시오.");
                                        Sb.subname = Console.ReadLine();
                                        Console.WriteLine("과목 대상 학년을 입력하여 주십시오.");
                                        Sb.targetgrade = int.Parse(Console.ReadLine());
                                        Console.WriteLine("과목 대상 학기를 입력하여 주십시오.");
                                        Sb.term = int.Parse(Console.ReadLine());
                                        Console.WriteLine("현재 등록된 학과:");
                                        foreach (var item in PartmentList)
                                        {
                                            if (item is Department)
                                            {
                                                Console.WriteLine((item as Department).departname);
                                            }
                                        }
                                        while (Sb.subdepart == null)
                                        {
                                            Console.WriteLine("교과목 학과를 입력하여주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in PartmentList)
                                            {
                                                if(item is Department)
                                                {
                                                    if ((item as Department).departname == inputstring)
                                                    {
                                                        Sb.subdepart = inputstring;
                                                        check = true;
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 학과입니다. 다시입력하여 주십시오.");
                                            }
                                        }
                                        Sb.lectureroomnumber = null;
                                        Sb.subProfesser = null;
                                        Sb.subAssistant = null;
                                        SubjectList.Add(Sb);
                                        Console.WriteLine("교과목이 정상적으로 추가되었습니다.");
                                        Console.ReadKey();
                                }
                                    else if (menu == "2")
                                        {
                                            check = false;
                                            Console.WriteLine("삭제하고자 하는 과목 이름을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach(var item in SubjectList)
                                            {
                                                if(item.subname == inputstring)
                                                {
                                                    check = true;
                                                }
                                            }
                                            if(check == true)
                                            {
                                                Console.WriteLine("정말로 " + inputstring + " 과목을 삭제하시겠습니까? 예:1 아니오:2");
                                                inputstring2 = Console.ReadLine();
                                                if(inputstring2 == "1")
                                                {
                                                    for (int i = SubjectList.Count - 1; i >= 0; i--)
                                                    {
                                                        if (SubjectList[i].subname == inputstring)
                                                        {
                                                            SubjectList.RemoveAt(i);
                                                        }
                                                    }
                                                    for (int j = EnrolmentList.Count - 1; j >= 0; j--)
                                                    {
                                                        if (EnrolmentList[j].subname == inputstring)
                                                        {
                                                            EnrolmentList.RemoveAt(j);
                                                        }
                                                    }
                                                    Console.WriteLine(inputstring + "과목을 삭제하였습니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if(check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 과목입니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if (menu == "3")
                                    {
                                        check = false;
                                        Console.WriteLine("검색하고자 하는 교과목 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SubjectList)
                                        {
                                            if (item.subname == inputstring || item.subdepart == inputstring || item.subProfesser == inputstring || item.lectureroomnumber == inputstring)
                                            {
                                                check = true;
                                                item.Pirnt_All_Moment();
                                                Console.ReadKey();
                                            }
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교과목입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                } while (menu != "4");
                                menu = "0";
                                break;
                        }
                    } while (menu != "5");
                    login = false;
                    Console.Clear();
                    }
                else if (mode == "Departmentadmin")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " Admin모드");
                        Console.WriteLine("1. 학생 관리, 2. 교직원 관리, 3. 수강 관리, 4. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 학생 관리 " + modename + " Admin모드");
                                    Console.WriteLine("1. 학생 변경, 2. 학생 검색, 3. 장학금 내역 입력 4. 나가기");
                                    menu = Console.ReadLine();
                                        if (menu == "1")
                                        {
                                            check = false;
                                            check2 = false;
                                            Console.WriteLine("변경하고자 하는 학생 정보를 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Student).StudentID == inputstring)
                                                    {
                                                        (item as IPrint).Pirnt_All_Moment();
                                                        check = true;
                                                        Console.WriteLine("변경할 학생 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            item.name = inputstring;
                                                        }
                                                        Console.WriteLine("변경할 학생 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            item.phonenumber = inputstring;
                                                        }
                                                        Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            item.email = inputstring;
                                                        }
                                                        Console.WriteLine("변경할 학번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            (item as Student).StudentID = inputstring;
                                                        }
                                                        while ((item as Student).Grade == 0)
                                                        {
                                                            Console.WriteLine("변경할 학년을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Student).Grade = int.Parse(inputstring);
                                                            }
                                                        }
                                                        Console.WriteLine("변경할 학생 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                        inputstring = Console.ReadLine();
                                                        if (inputstring != "")
                                                        {
                                                            foreach (var item2 in PartmentList)
                                                            {
                                                                if (item2 is Department)
                                                                {
                                                                    if ((item2 as Department).departname == inputstring)
                                                                    {
                                                                        check2 = true;
                                                                        item.depart = inputstring;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        if (check2 == false && inputstring != "")
                                                        {
                                                            Console.WriteLine("존재하지 않는 학과입니다.");
                                                        }
                                                        (item as IPrint).Pirnt_All_Moment();
                                                        Console.WriteLine("변경된 학생 정보를 확인하십시오.");
                                                        Console.ReadKey();
                                                    }
                                                }
                                            }

                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 학생입니다.");
                                                Console.ReadKey();
                                            }

                                        }
                                        else if (menu == "2")
                                        {
                                            check = false;
                                            Console.WriteLine("검색하고자 하는 학생 정보를 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Student).StudentID == inputstring || item.depart == inputstring)
                                                    {
                                                        check = true;
                                                        (item as IPrint).Pirnt_All_Moment();
                                                        Console.ReadKey();
                                                    }
                                                }

                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 학생입니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                        else if (menu == "3")
                                        {
                                            check = false;
                                            Console.WriteLine("장학금 수혜 내역을 입력하고자 하는 학생 학번을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if ((item as Student).StudentID == inputstring && (item as Student).depart == modename)
                                                    {
                                                        check = true;
                                                        Scholarship Sc = new Scholarship();
                                                        Console.WriteLine("수혜받은 장학금 이름을 입력하여 주십시오.");
                                                        Sc.title = Console.ReadLine();
                                                        while (Sc.Money == 0)
                                                        {
                                                            Console.WriteLine("수혜받은 장학금 금액을 입력하여 주십시오. (만원 단위)");
                                                            Sc.Money = int.Parse(Console.ReadLine());
                                                        }
                                                        (item as Student).Scholarships.Add(Sc);
                                                        Console.WriteLine("정상적으로 장학금내역이 추가되었습니다.");
                                                        Console.ReadKey();
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지않는 학생 이거나 타 학과 학생입니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                } while (menu != "4");
                                menu = "0";
                                break;
                            case "2":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 교직원 관리 " + modename + " Admin모드");
                                    Console.WriteLine("1. 교직원 변경, 2. 교직원 검색, 3. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                        check = false;
                                        check2 = false;
                                        Console.WriteLine("변경하고자 하는 교직원 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                                if (item is Professor)
                                                {
                                                    if ((item as Professor).depart == modename)
                                                    {
                                                        if ((item as Professor).name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Professor).businessnumber == inputstring && (item as Professor).depart == modename)
                                                        {
                                                            (item as IPrint).Pirnt_All_Moment();
                                                            check = true;
                                                            Console.WriteLine("변경할 교수 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.name = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 교수 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Professor).businessnumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 교수 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.phonenumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 교수 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.email = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 교수 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                foreach (var item2 in PartmentList)
                                                                {
                                                                    if (item2 is Department)
                                                                    {
                                                                        if ((item2 as Department).departname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (check2 == false && inputstring != "")
                                                            {
                                                                Console.WriteLine("존재하지 않는 학과입니다.");
                                                            }
                                                            Console.WriteLine("변경할 교수 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Professor).Salay = int.Parse(inputstring);
                                                            }
                                                            while ((item as Professor).Salay == 0)
                                                            {
                                                                inputstring = Console.ReadLine();
                                                                if (inputstring != "")
                                                                {
                                                                    (item as Professor).Salay = int.Parse(inputstring);
                                                                }
                                                            }
                                                            Console.WriteLine("변경할 교수 직급을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Professor).rank = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 교수 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Professor).dataenty = int.Parse(inputstring);
                                                            }
                                                        (item as IPrint).Pirnt_All_Moment();
                                                            Console.WriteLine("변경된 교수 정보를 확인하십시오.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                else if (item is Assistant)
                                                {
                                                    if ((item as Assistant).depart == modename)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring)
                                                        {
                                                            (item as IPrint).Pirnt_All_Moment();
                                                            check = true;
                                                            Console.WriteLine("변경할 조교 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.name = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).businessnumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.phonenumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.email = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                foreach (var item2 in PartmentList)
                                                                {
                                                                    if (item2 is Department)
                                                                    {
                                                                        if ((item2 as Department).departname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                    if (item2 is Team)
                                                                    {
                                                                        if ((item2 as Team).teamname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (check2 == false && inputstring != "")
                                                            {
                                                                Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                            }
                                                            Console.WriteLine("변경할 조교 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).Salay = int.Parse(inputstring);
                                                            }
                                                            while ((item as Assistant).Salay == 0)
                                                            {
                                                                inputstring = Console.ReadLine();
                                                                if (inputstring != "")
                                                                {
                                                                    (item as Assistant).Salay = int.Parse(inputstring);
                                                                }
                                                            }
                                                            Console.WriteLine("변경할 조교 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).dataenty = int.Parse(inputstring);
                                                            }
                                                                (item as IPrint).Pirnt_All_Moment();

                                                            Console.WriteLine("변경된 조교 정보를 확인하십시오.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                else if (item is Staff)
                                                {
                                                    if ((item as Staff).depart == modename)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring && (item as Staff).depart == modename)
                                                        {
                                                            (item as IPrint).Pirnt_All_Moment();
                                                            check = true;
                                                            Console.WriteLine("변경할 직원 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.name = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).businessnumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.phonenumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.email = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 학과 혹은 부서를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과, 부서일시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                foreach (var item2 in PartmentList)
                                                                {
                                                                    if (item2 is Department)
                                                                    {
                                                                        if ((item2 as Department).departname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                    if (item2 is Team)
                                                                    {
                                                                        if ((item2 as Team).teamname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (check2 == false && inputstring != "")
                                                            {
                                                                Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                            }
                                                            Console.WriteLine("변경할 직원 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).Salay = int.Parse(inputstring);
                                                            }
                                                            while ((item as Staff).Salay == 0)
                                                            {
                                                                inputstring = Console.ReadLine();
                                                                if (inputstring != "")
                                                                {
                                                                    (item as Staff).Salay = int.Parse(inputstring);
                                                                }
                                                            }
                                                            Console.WriteLine("변경할 직원 직급을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).rank = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).dataenty = int.Parse(inputstring);
                                                            }
                                                            (item as IPrint).Pirnt_All_Moment();
                                                            Console.WriteLine("변경된 직원 정보를 확인하십시오.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교직원 혹은 수정 권한이 없는 교직원입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (menu == "2")
                                    {
                                        check = false;
                                        Console.WriteLine("검색하고자 하는 교직원 정보를 입력하여 주십시오.");
                                        inputstring = Console.ReadLine();
                                        foreach (var item in SchoolHumanList)
                                        {
                                            if (item is Professor)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Professor).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Assistant)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (item is Staff)
                                            {
                                                if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring || item.depart == inputstring)
                                                {
                                                    (item as IPrint).Pirnt_All_Moment();
                                                    Console.WriteLine("");
                                                    check = true;
                                                    Console.ReadKey();
                                                }
                                            }
                                        }
                                        if (check == false)
                                        {
                                            Console.WriteLine("존재하지 않는 교직원입니다.");
                                            Console.ReadKey();
                                        }
                                    }
                                } while (menu != "3");
                                menu = "0";
                                break;
                            case "3":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 수강 관리 " + modename + " Admin모드");
                                    Console.WriteLine("1. 과목 개설, 2. 교수 배정, 3. 조교 배정, 4. 교수, 조교 배정 철회 5. 강의실 배정,변경, 6. 학생 수강 등록, 7. 학생 수강 제거, 8. 과목 정보보기 9. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                            Subject Sb = new Subject();
                                            Console.WriteLine("과목 이름을 입력하여 주십시오.");
                                            Sb.subname = Console.ReadLine();
                                            Console.WriteLine("과목 대상 학년을 입력하여 주십시오.");
                                            Sb.targetgrade = int.Parse(Console.ReadLine());
                                            Console.WriteLine("과목 대상 학기를 입력하여 주십시오.");
                                            Sb.term = int.Parse(Console.ReadLine());
                                            Sb.subdepart = modename;
                                            Sb.lectureroomnumber = null;
                                            Sb.subProfesser = null;
                                            Sb.subAssistant = null;
                                            SubjectList.Add(Sb);
                                            Console.WriteLine("교과목이 정상적으로 추가되었습니다.");
                                            Console.ReadKey();
                                        }
                                    else if (menu == "2")
                                    {
                                            check = false;
                                            check2 = false;
                                            Console.WriteLine("배정하고자 하는 교수 이름을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach(var item in SchoolHumanList)
                                            {
                                                if(item.name == inputstring)
                                                {
                                                    check = true;
                                                }
                                            }
                                            if (check == true) { 
                                            Console.WriteLine("배정하고자 하는 과목 이름을 입력하여 주십시오.");
                                            inputstring2 = Console.ReadLine();
                                            foreach(var item in SubjectList)
                                            {
                                                if(item.subname == inputstring2 && item.subProfesser == null)
                                                {
                                                    item.subProfesser = inputstring;
                                                    check2 = true;
                                                    Console.WriteLine("정상적으로 교수가 배정되었습니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            foreach (var item in SchoolHumanList)
                                            {
                                                foreach(var item2 in SubjectList)
                                                {
                                                    
                                                    if (item.name == inputstring && item2.subProfesser == inputstring)
                                                    {
                                                        if (item2.subname == inputstring2)
                                                        {
                                                            (item as Professor).subjects.Add(item2);
                                                        }   
                                                    }
                                                }
                                            }
                                            }
                                            if (check2 == false)
                                            {
                                                Console.WriteLine("없는 과목, 교수 혹은 이미 교수가 배정된 상태입니다. 다시입력하여 주십시오.");
                                                Console.ReadKey();
                                            }
                                    }
                                        else if (menu == "3")
                                        {
                                            check = false;
                                            check2 = false;
                                            Console.WriteLine("배정하고자 하는 조교 이름을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item.name == inputstring)
                                                {
                                                    check = true;
                                                }
                                            }
                                            if (check == true)
                                            {
                                                Console.WriteLine("배정하고자 하는 과목 이름을 입력하여 주십시오.");
                                                inputstring2 = Console.ReadLine();
                                                foreach (var item in SubjectList)
                                                {
                                                    if (item.subname == inputstring2 && item.subAssistant == null)
                                                    {
                                                        item.subAssistant = inputstring;
                                                        check2 = true;
                                                        Console.WriteLine("정상적으로 조교가 배정되었습니다.");
                                                        Console.ReadKey();
                                                    }
                                                }
                                                foreach (var item in SchoolHumanList)
                                                {
                                                    foreach (var item2 in SubjectList)
                                                    {

                                                        if (item.name == inputstring && item2.subAssistant == inputstring)
                                                        {
                                                            if (item2.subname == inputstring2)
                                                            {
                                                                (item as Assistant).Assubjects.Add(item2);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (check2 == false)
                                            {
                                                Console.WriteLine("없는 과목, 조교 혹은 이미 조교가 배정된 상태입니다. 다시입력하여 주십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                        else if (menu == "4")
                                        {
                                            check = false;
                                            Console.WriteLine("배정을 철회 하는 과목 이름을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SubjectList)
                                            {
                                                if (item.subname == inputstring)
                                                {
                                                    Console.WriteLine("배정을 철회하고자 하는 교수 혹은 조교의 유형을 입력하여 주십시오.");
                                                    inputstring = Console.ReadLine();
                                                    for (int i = SchoolHumanList.Count - 1; i >= 0; i--)
                                                    {
                                                        if ("교수" == inputstring && item.subProfesser != null)
                                                        { 
                                                            if (SchoolHumanList[i] is Professor)
                                                            {
                                                                if (SchoolHumanList[i].name == item.subProfesser)
                                                                {
                                                                    item.subProfesser = null;
                                                                    for (int j = (SchoolHumanList[i] as Professor).subjects.Count - 1; j >= 0; j--)
                                                                    {
                                                                        if ((SchoolHumanList[i] as Professor).subjects[j].subname == item.subname)
                                                                        {
                                                                            (SchoolHumanList[i] as Professor).subjects.RemoveAt(j);
                                                                        }
                                                                    }
                                                                    check = true;
                                                                    Console.WriteLine("정상적으로 교수가 철회되었습니다.");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                        if ("조교" == inputstring && item.subAssistant != null)
                                                        { 
                                                            if (SchoolHumanList[i] is Assistant)
                                                            {
                                                                if (SchoolHumanList[i].name == item.subAssistant)
                                                                {
                                                                    item.subAssistant = null;
                                                                    for (int j = (SchoolHumanList[i] as Assistant).Assubjects.Count - 1; j >= 0; j--)
                                                                    {
                                                                        if ((SchoolHumanList[i] as Assistant).Assubjects[j].subname == item.subname)
                                                                        {
                                                                            (SchoolHumanList[i] as Assistant).Assubjects.RemoveAt(j);
                                                                        }
                                                                    }
                                                                    check = true;
                                                                    Console.WriteLine("정상적으로 조교가 철회되었습니다.");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("없는 과목 혹은 교수 및 조교가 미배정 상태입니다. 다시입력하여 주십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if (menu == "5")
                                    {
                                            check = false;
                                            Console.WriteLine("배정하고자 하는 과목 이름을 입력하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SubjectList)
                                            {
                                                if (item.subname == inputstring)
                                                {
                                                    check = true;
                                                    Console.WriteLine("배정하고자 하는 강의실 번호를 입력하여 주십시오.");
                                                    inputstring = Console.ReadLine();
                                                    item.lectureroomnumber = inputstring;
                                                    Console.WriteLine("정상적으로 강의실이 배정되었습니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("없는 과목입니다. 다시입력하여 주십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if (menu == "6")
                                    {
                                            check = false;
                                            check2 = true;
                                            foreach (var item in SubjectList)
                                            {
                                                Console.WriteLine(item.subname);
                                            }
                                            Console.WriteLine("수강 신청할 과목을 선택하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            Console.WriteLine("신청하고자 하는 학생 이름을 입력하십시오.");
                                            inputstring2 = Console.ReadLine();
                                            Console.WriteLine("신청하고자 하는 학생 학번을 입력하십시오.");
                                            inputstring3 = Console.ReadLine();
                                            foreach(var list in EnrolmentList)
                                            {
                                                if(list.offerStuID == inputstring3)
                                                {
                                                    check = true;
                                                    check2 = false;
                                                    Console.WriteLine("이미 수강신청된 과목입니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if(check2 == true)
                                            {
                                                USStudent Stu = new USStudent();
                                                foreach (var item in SubjectList)
                                                {
                                                    foreach (var item2 in SchoolHumanList)
                                                    {
                                                        if (item2 is Student)
                                                        {
                                                            if ((item2 as Student).StudentID == inputstring3)
                                                            {
                                                                if (item.subname == inputstring && item.term == globalterm)
                                                                {
                                                                    check = true;
                                                                    Stu.subname = item.subname;
                                                                    Stu.subdepart = item.subdepart;
                                                                    Stu.subProfesser = item.subProfesser;
                                                                    Stu.subAssistant = item.subAssistant;
                                                                    Stu.lectureroomnumber = item.lectureroomnumber;
                                                                    Stu.targetgrade = item.targetgrade;
                                                                    Stu.term = item.term;

                                                                    Stu.studentname = inputstring2;
                                                                    Stu.studentgrade = (item2 as Student).Grade;
                                                                    Stu.offerStuID = inputstring3;
                                                                    Stu.ratingend = false;
                                                                    EnrolmentList.Add(Stu);
                                                                    Console.WriteLine("성공적으로 수강신청이 완료되었습니다.");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 과목 혹은 학기가 맞지 않는 과목입니다. 혹은 존재하지 않는 학생입니다. 다시 입력바랍니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if (menu == "7")
                                    {
                                            check = false;
                                            Console.WriteLine("수강 제거할 학생의 이름을 입력하십시오.");
                                            inputstring = Console.ReadLine();
                                            Console.WriteLine("수강 제거할 학생의 학번을 입력하십시오.");
                                            inputstring2 = Console.ReadLine();
                                            Console.WriteLine(inputstring + "학생의 수강신청리스트");
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.studentname == inputstring && item.offerStuID == inputstring2)
                                                {
                                                    Console.WriteLine(item.subname);
                                                }
                                            }
                                            Console.WriteLine("수강 신청을 변경할 과목을 선택하여 주십시오.");
                                            inputstring3 = Console.ReadLine();
                                            for (int i = EnrolmentList.Count - 1; i >= 0; i--)
                                            {
                                                if (EnrolmentList[i].studentname == inputstring && EnrolmentList[i].offerStuID == inputstring2)
                                                {
                                                    if (EnrolmentList[i].subname == inputstring3)
                                                    {
                                                        Console.WriteLine(inputstring + " 과목을 정말로 삭제하시겠습니까?");
                                                        Console.WriteLine("예: 1, 아니오: 2");
                                                        inputstring2 = Console.ReadLine();
                                                        if (inputstring2 == "1")
                                                        {
                                                            EnrolmentList.RemoveAt(i);
                                                            check = true;
                                                            Console.WriteLine("성공적으로 수강신청 제거가 완료되었습니다.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 과목 혹은 없는 학생입니다. 다시 입력바랍니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if(menu == "8")
                                        {
                                            check = false;
                                            Console.WriteLine("검색하고자 하는 교과목 정보를 입력하여 주십시오. 추가적인 수강생정보는 과목 이름만 지원합니다.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in SubjectList)
                                            {
                                                if (item.subname == inputstring || item.subdepart == inputstring || item.subProfesser == inputstring || item.lectureroomnumber == inputstring)
                                                {
                                                    check = true;
                                                    item.Pirnt_All_Moment();
                                                    Console.ReadKey();
                                                }
                                            }
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.subname == inputstring)
                                                {
                                                    check = true;
                                                    Console.WriteLine(inputstring + "과목의 수강생정보:");
                                                    Console.WriteLine("학생 이름: " + item.studentname);
                                                    Console.WriteLine("학생 학년: " + item.studentgrade);
                                                    Console.WriteLine("학생 학번: " + item.offerStuID);
                                                    Console.WriteLine("");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 교과목입니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                } while (menu != "9");
                                menu = "0";
                                break;
                        }
                    } while (menu != "4");
                        login = false;
                        Console.Clear();
                    }
                else if (mode == "Professor")
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " 교수모드");
                        Console.WriteLine("1. 본인 정보 변경, 2. 강의 과목 관리, 3. 본인 정보 확인, 4. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Professor)
                                        {
                                            if ((item as Professor).name == modename && (item as Professor).businessnumber == globalbusnumber)
                                            {
                                                (item as Professor).Pirnt_All_Moment();
                                                check = true;
                                                Console.WriteLine("변경할 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.name = inputstring;
                                                }
                                                Console.WriteLine("변경할 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.phonenumber = inputstring;
                                                }
                                                Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.email = inputstring;
                                                }
                                                    (item as Professor).Pirnt_All_Moment();
                                                Console.WriteLine("변경된 정보를 확인하십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                            case "2":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 교수 강의 과목 관리 " + modename + " Admin모드");
                                    Console.WriteLine("1. 강의 과목 확인, 2. 수강생 정보 확인, 3. 과목별 성적 기입, 4. 학생별 성적기입 5. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                            Console.WriteLine(modename + "교수님의 강의 과목:");
                                            foreach(var item in SubjectList)
                                            {
                                                if(item.subProfesser == modename)
                                                {
                                                    Console.WriteLine(item.subname);
                                                }
                                            }
                                            Console.ReadKey();
                                    }
                                    else if (menu == "2")
                                    {
                                            check = false;
                                            check2 = false;
                                            Console.WriteLine("수강생 정보확인을 원하시는 과목을 입력하여주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach(var item in SubjectList)
                                            {
                                                if(item.subname == inputstring && item.subProfesser == modename)
                                                {
                                                    check2 = true;
                                                }
                                            }
                                            foreach (var item in EnrolmentList)
                                            {
                                                if(item.subname == inputstring && item.subProfesser == modename)
                                                {
                                                    check = true;
                                                    Console.WriteLine(inputstring + " 과목의 수강생정보:");
                                                    Console.WriteLine("학생 이름: " + item.studentname);
                                                    Console.WriteLine("학생 학년: " + item.studentgrade);
                                                    Console.WriteLine("학생 학번: " + item.offerStuID);
                                                    Console.WriteLine("");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if(check == false && check2 == true)
                                            {
                                                Console.WriteLine("수강생이 존재하지 않습니다.");
                                                Console.ReadKey();
                                            }
                                            if (check == false && check2 == false)
                                            {
                                                Console.WriteLine("교수님의 배정강의가 아닙니다.");
                                                Console.ReadKey();
                                            }
                                    }
                                    else if (menu == "3")
                                    {
                                            check = false;
                                            check2 = false;
                                            check3 = false;
                                            Console.WriteLine("과목별 성적기입 모드입니다.");
                                            Console.WriteLine("성적을 입력할 과목을 입력해주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach(var item in SubjectList)
                                            {
                                                if(item.subname == inputstring && item.subProfesser == modename)
                                                {
                                                    check2 = true;
                                                }
                                            }
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.subname == inputstring && item.subProfesser == modename)
                                                {
                                                    Console.WriteLine(item.studentname + "학생");
                                                    check = true;
                                                    SubjectEnd End = new SubjectEnd
                                                    {
                                                        subname = item.subname,
                                                        subdepart = item.subdepart,
                                                        subProfesser = item.subProfesser,
                                                        studentname = item.studentname,
                                                        StudentID = item.offerStuID,
                                                        studentgrade = item.studentgrade,
                                                        term = item.term,
                                                        ratingend = true
                                                    };
                                                    while (End.Getrecordal() == null)
                                                    {
                                                        Console.WriteLine("입력하고자하는 등급을 입력해주십시오.");
                                                        inputstring2 = Console.ReadLine();
                                                        End.Setrecord(inputstring2);
                                                    }
                                                    while (End.Getrecordnumber() == 0)
                                                    {
                                                        Console.WriteLine("입력하고자하는 성적을 입력해주십시오.");
                                                        inputstring3 = Console.ReadLine();
                                                        try {
                                                        End.Setrecord(double.Parse(inputstring3));
                                                        }
                                                        catch(Exception)
                                                        {
                                                            Console.WriteLine("비정상적인 값을 입력하였습니다.");
                                                            End.Setrecord(0);
                                                        }
                                                    }
                                                    Console.WriteLine("정말로 이 성적을 입력하시겠습니까? 예: 1, 아니오: 2");
                                                    inputstring2 = Console.ReadLine();
                                                    if(inputstring2 == "1")
                                                    {
                                                        check3 = true;
                                                        item.ratingend = true;
                                                        SubjectEnd SEnd = End;
                                                        foreach (var item2 in SchoolHumanList)
                                                        {
                                                            if (item2 is Student)
                                                            {
                                                                if (item2.name == SEnd.studentname && (item2 as Student).StudentID == SEnd.StudentID)
                                                                {
                                                                    (item2 as Student).SubejctEndlist.Add(SEnd);
                                                                    
                                                                    Console.WriteLine(item.studentname + "학생의 성적을 성공적으로 입력하였습니다.");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if(check3 == true)
                                            {
                                                for (int i = EnrolmentList.Count - 1; i >= 0; i--)
                                                {
                                                    if (EnrolmentList[i].ratingend == true)
                                                    {
                                                        EnrolmentList.RemoveAt(i);
                                                    }
                                                }
                                            }
                                            if (check == false && check2 == true)
                                            {
                                                Console.WriteLine("성적을 입력할 학생이 존재하지 않습니다.");
                                                Console.ReadKey();
                                            }
                                            if (check == false && check2 == false)
                                            {
                                                Console.WriteLine("교수님의 배정강의가 아니거나, 데이터를 잘못입력하였습니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    else if (menu == "4")
                                    {
                                            check = false;
                                            check2 = false;
                                            Console.WriteLine("학생별 성적기입 모드입니다.");
                                            Console.WriteLine("성적을 입력할 학생을 입력해주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.studentname == inputstring && item.subProfesser == modename)
                                                {
                                                    Console.WriteLine(item.studentname + "학생");
                                                    Console.WriteLine(item.subname + "과목");
                                                    check = true;
                                                    SubjectEnd End = new SubjectEnd
                                                    {
                                                        subname = item.subname,
                                                        subdepart = item.subdepart,
                                                        subProfesser = item.subProfesser,
                                                        studentname = item.studentname,
                                                        StudentID = item.offerStuID,
                                                        studentgrade = item.studentgrade,
                                                        term = item.term,
                                                        ratingend = true
                                                    };
                                                    while (End.Getrecordal() == null)
                                                    {
                                                        Console.WriteLine("입력하고자하는 등급을 입력해주십시오.");
                                                        inputstring2 = Console.ReadLine();
                                                        End.Setrecord(inputstring2);
                                                    }
                                                    while (End.Getrecordnumber() == 0)
                                                    {
                                                        Console.WriteLine("입력하고자하는 성적을 입력해주십시오.");
                                                        inputstring3 = Console.ReadLine();
                                                        try
                                                        {
                                                            End.Setrecord(double.Parse(inputstring3));
                                                        }
                                                        catch (Exception)
                                                        {
                                                            Console.WriteLine("비정상적인 값을 입력하였습니다.");
                                                            End.Setrecord(0);
                                                        }
                                                    }
                                                    Console.WriteLine("정말로 이 성적을 입력하시겠습니까? 예: 1, 아니오: 2");
                                                    inputstring2 = Console.ReadLine();
                                                    if (inputstring2 == "1")
                                                    {
                                                        check2 = true;
                                                        item.ratingend = true;
                                                        SubjectEnd SEnd = End;
                                                        foreach (var item2 in SchoolHumanList)
                                                        {
                                                            if (item2 is Student)
                                                            {
                                                                if (item2.name == SEnd.studentname && (item2 as Student).StudentID == SEnd.StudentID)
                                                                {
                                                                    (item2 as Student).SubejctEndlist.Add(SEnd);
                                                                    Console.WriteLine(item.studentname + "학생의 성적을 성공적으로 입력하였습니다.");
                                                                    Console.ReadKey();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if (check2 == true)
                                            {
                                                for (int i = EnrolmentList.Count - 1; i >= 0; i--)
                                                {
                                                    if (EnrolmentList[i].ratingend == true)
                                                    {
                                                        EnrolmentList.RemoveAt(i);
                                                    }
                                                }
                                            }
                                            if (check == false && check2 == false)
                                            {
                                                Console.WriteLine("학생 내의 성적을 입력할 과목이 존재하지 않습니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    } while (menu != "5");
                                menu = "0";
                                break;
                            case "3":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Professor)
                                        {
                                            if ((item as Professor).name == modename && (item as Professor).businessnumber == globalbusnumber)
                                            {
                                                (item as Professor).Pirnt_All_Moment();
                                                Console.WriteLine("");
                                                check = true;
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                menu = "0";
                                break;
                        }
                    } while (menu != "4");
                        login = false;
                        Console.Clear();
                    }
                else if (mode == "Student")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " 학생모드");
                        Console.WriteLine("1. 본인 정보 변경, 2. 수강 관리 3. 성적 확인, 4. 본인 정보 확인, 5. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Student)
                                        {
                                            if ((item as Student).name == modename && (item as Student).StudentID == globalstunumber)
                                            {
                                                (item as Student).Pirnt_All_Moment();
                                                check = true;
                                                Console.WriteLine("변경할 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.name = inputstring;
                                                }
                                                Console.WriteLine("변경할 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.phonenumber = inputstring;
                                                }
                                                Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.email = inputstring;
                                                }
                                                    (item as Student).Pirnt_All_Moment();
                                                Console.WriteLine("변경된 정보를 확인하십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                            case "2":
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("한남대학교 수강 관리 " + modename + " 학생모드");
                                        Console.WriteLine("1. 수강 신청, 2. 수강 변경, 3. 현재 학기 등록과목 확인 4. 나가기");
                                        menu = Console.ReadLine();
                                        if (menu == "1")
                                        {
                                            check = false;
                                            foreach (var item in SubjectList)
                                            {
                                                    Console.WriteLine(item.subname);
                                            }
                                            Console.WriteLine("수강 신청할 과목을 선택하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            USStudent Stu = new USStudent();
                                            foreach (var item in SubjectList)
                                            {
                                                foreach (var item2 in SchoolHumanList)
                                                {
                                                    if(item2 is Student)
                                                    {
                                                        if(item2.name == modename && (item2 as Student).StudentID == globalstunumber)
                                                        {
                                                            if (item.subname == inputstring && item.term == globalterm)
                                                            {
                                                                check = true;
                                                                Stu.subname = item.subname;
                                                                Stu.subdepart = item.subdepart;
                                                                Stu.subProfesser = item.subProfesser;
                                                                Stu.subAssistant = item.subAssistant;
                                                                Stu.lectureroomnumber = item.lectureroomnumber;
                                                                Stu.targetgrade = item.targetgrade;
                                                                Stu.term = item.term;

                                                                Stu.studentname = modename;
                                                                Stu.studentgrade = (item2 as Student).Grade;
                                                                Stu.offerStuID = globalstunumber;
                                                                Stu.ratingend = false;
                                                                EnrolmentList.Add(Stu);
                                                                Console.WriteLine("성공적으로 수강신청이 완료되었습니다.");
                                                                Console.ReadKey();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            if(check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 과목 혹은 학기가 맞지 않는 과목입니다. 다시 입력바랍니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                        else if (menu == "2")
                                        {
                                            check = false;
                                            Console.WriteLine(modename + "학생의 수강신청리스트");
                                            foreach (var item in EnrolmentList)
                                            {
                                                if(item.studentname == modename && item.offerStuID == globalstunumber)
                                                {
                                                    Console.WriteLine(item.subname);
                                                }
                                            }
                                            Console.WriteLine("수강 신청을 변경할 과목을 선택하여 주십시오.");
                                            inputstring = Console.ReadLine();
                                            for (int i = EnrolmentList.Count - 1; i >= 0; i--)
                                            {
                                                if (EnrolmentList[i].studentname == modename && EnrolmentList[i].offerStuID == globalstunumber)
                                                {
                                                    if(EnrolmentList[i].subname == inputstring)
                                                    {
                                                        Console.WriteLine(inputstring + " 과목을 정말로 삭제하시겠습니까?");
                                                        Console.WriteLine("예: 1, 아니오: 2");
                                                        inputstring2 = Console.ReadLine();
                                                        if(inputstring2 == "1")
                                                        {
                                                            EnrolmentList.RemoveAt(i);
                                                            check = true;
                                                            Console.WriteLine("성공적으로 수강신청 변경이 완료되었습니다.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                            }
                                            if(check == false)
                                            {
                                                Console.WriteLine("존재하지 않는 과목입니다. 다시 입력바랍니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                        else if(menu == "3")
                                        {
                                            check = false;
                                            Console.WriteLine(modename + "학생의 " + globalterm + "학기 " +"수강신청리스트");
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.studentname == modename && item.offerStuID == globalstunumber)
                                                {
                                                    if(item.term == globalterm)
                                                    {
                                                        check = true;
                                                        Console.WriteLine(item.subname);
                                                        Console.ReadKey();
                                                    }
                                                }
                                            }
                                            if(check == false)
                                            {
                                                Console.WriteLine("수강신청한 내역이 존재하지않습니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                    } while (menu != "4");
                                    menu = "0";
                                    break;
                            case "3":
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("한남대학교 성적 관리 " + modename + " 학생모드");
                                        Console.WriteLine("1. 과거 수강과목 확인, 2. 성적 확인, 3. 평점 평균 확인 4. 나가기");
                                        menu = Console.ReadLine();
                                        if (menu == "1")
                                        {
                                            Console.WriteLine(modename + "학생의 과거 수강과목 리스트");
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if (item.name == modename && (item as Student).StudentID == globalstunumber)
                                                    {
                                                        foreach(var item2 in (item as Student).SubejctEndlist)
                                                        {
                                                            Console.WriteLine(item2.subname);
                                                            
                                                        } 
                                                    }
                                                }
                                            }
                                            Console.ReadKey();
                                        }
                                        else if (menu == "2")
                                        {
                                            Console.WriteLine(modename + "학생의 성적");
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if (item.name == modename && (item as Student).StudentID == globalstunumber)
                                                    {
                                                        foreach (var item2 in (item as Student).SubejctEndlist)
                                                        {
                                                            Console.WriteLine(item2.subname);
                                                            Console.WriteLine("등급: " + item2.Getrecordal());
                                                            Console.WriteLine("평점: " + item2.Getrecordnumber());
                                                            Console.WriteLine("");
                                                        }
                                                    }
                                                }
                                            }
                                            Console.ReadKey();
                                        }
                                        else if (menu == "3")
                                        { 
                                            Avgscore = 0;
                                            Count = 0;
                                            Console.WriteLine(modename + "학생의 평균 성적");
                                            foreach (var item in SchoolHumanList)
                                            {
                                                if (item is Student)
                                                {
                                                    if (item.name == modename && (item as Student).StudentID == globalstunumber)
                                                    {
                                                        foreach (var item2 in (item as Student).SubejctEndlist)
                                                        {
                                                            Avgscore += item2.Getrecordnumber();
                                                            Count++;
                                                        }
                                                    }
                                                }
                                            }
                                                Console.WriteLine("평균 평점: " + Math.Round(Avgscore / Count,1));
                                                Console.ReadKey();
                                        }
                                    } while (menu != "4");
                                menu = "0";
                                break;
                            case "4":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Student)
                                        {
                                            if ((item as Student).name == modename && (item as Student).StudentID == globalstunumber)
                                            {
                                                (item as Student).Pirnt_All_Moment();
                                                Console.WriteLine("");
                                                check = true;
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                menu = "0";
                                break;
                        }
                    } while (menu != "5");
                        login = false;
                        Console.Clear();
                    }
                else if (mode == "Teamadmin") {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " Admin모드");
                        Console.WriteLine("1. 직원 관리, 2. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("한남대학교 교직원 관리 " + modename + " Admin모드");
                                        Console.WriteLine("1. 교직원 변경, 2. 교직원 검색, 3. 나가기");
                                        menu = Console.ReadLine();
                                            if (menu == "1")
                                            {
                                                check = false;
                                                check2 = false;
                                                Console.WriteLine("변경하고자 하는 교직원 정보를 입력하여 주십시오.");
                                                inputstring = Console.ReadLine();
                                                foreach (var item in SchoolHumanList)
                                                {
                                                    if (item is Assistant)
                                                    {
                                                    if ((item as Assistant).depart == modename)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring && (item as Assistant).depart == modename)
                                                        {
                                                            (item as Assistant).Pirnt_All_Moment();
                                                            check = true;
                                                            Console.WriteLine("변경할 조교 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.name = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).businessnumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.phonenumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.email = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 조교 학과를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과일시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                foreach (var item2 in PartmentList)
                                                                {
                                                                    if (item2 is Department)
                                                                    {
                                                                        if ((item2 as Department).departname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                    if (item2 is Team)
                                                                    {
                                                                        if ((item2 as Team).teamname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (check2 == false && inputstring != "")
                                                            {
                                                                Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                            }
                                                            Console.WriteLine("변경할 조교 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).Salay = int.Parse(inputstring);
                                                            }
                                                            while ((item as Assistant).Salay == 0)
                                                            {
                                                                inputstring = Console.ReadLine();
                                                                if (inputstring != "")
                                                                {
                                                                    (item as Assistant).Salay = int.Parse(inputstring);
                                                                }
                                                            }
                                                            Console.WriteLine("변경할 조교 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Assistant).dataenty = int.Parse(inputstring);
                                                            }
                                                                (item as Assistant).Pirnt_All_Moment();

                                                            Console.WriteLine("변경된 조교 정보를 확인하십시오.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                else if (item is Staff)
                                                {
                                                    if ((item as Staff).depart == modename)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring && (item as Staff).depart == modename)
                                                        {
                                                            (item as Staff).Pirnt_All_Moment();
                                                            check = true;
                                                            Console.WriteLine("변경할 직원 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.name = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 사번을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).businessnumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.phonenumber = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                item.email = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 학과 혹은 부서를 입력하여 주십시오. 공백으로 두거나 혹은 없는 학과, 부서일시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                foreach (var item2 in PartmentList)
                                                                {
                                                                    if (item2 is Department)
                                                                    {
                                                                        if ((item2 as Department).departname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                    if (item2 is Team)
                                                                    {
                                                                        if ((item2 as Team).teamname == inputstring)
                                                                        {
                                                                            check2 = true;
                                                                            item.depart = inputstring;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (check2 == false && inputstring != "")
                                                            {
                                                                Console.WriteLine("존재하지 않는 학과 혹은 부서입니다.");
                                                            }
                                                            Console.WriteLine("변경할 직원 월급여를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).Salay = int.Parse(inputstring);
                                                            }
                                                            while ((item as Staff).Salay == 0)
                                                            {
                                                                inputstring = Console.ReadLine();
                                                                if (inputstring != "")
                                                                {
                                                                    (item as Staff).Salay = int.Parse(inputstring);
                                                                }
                                                            }
                                                            Console.WriteLine("변경할 직원 직급을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).rank = inputstring;
                                                            }
                                                            Console.WriteLine("변경할 직원 입사일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                            inputstring = Console.ReadLine();
                                                            if (inputstring != "")
                                                            {
                                                                (item as Staff).dataenty = int.Parse(inputstring);
                                                            }
                                                                (item as Staff).Pirnt_All_Moment();
                                                            Console.WriteLine("변경된 직원 정보를 확인하십시오.");
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("존재하지 않는 교직원 혹은 수정 권한이 없는 교직원입니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (menu == "2")
                                            {
                                                check = false;
                                                Console.WriteLine("검색하고자 하는 교직원 정보를 입력하여 주십시오.");
                                                inputstring = Console.ReadLine();
                                                foreach (var item in SchoolHumanList)
                                                {
                                                    if (item is Professor)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Professor).businessnumber == inputstring || item.depart == inputstring)
                                                        {
                                                            (item as Professor).Pirnt_All_Moment();
                                                            Console.WriteLine("");
                                                            check = true;
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                    else if (item is Assistant)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Assistant).businessnumber == inputstring || item.depart == inputstring)
                                                        {
                                                            (item as Assistant).Pirnt_All_Moment();
                                                            Console.WriteLine("");
                                                            check = true;
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                    else if (item is Staff)
                                                    {
                                                        if (item.name == inputstring || item.phonenumber == inputstring || item.email == inputstring || (item as Staff).businessnumber == inputstring || item.depart == inputstring)
                                                        {
                                                            (item as Staff).Pirnt_All_Moment();
                                                            Console.WriteLine("");
                                                            check = true;
                                                            Console.ReadKey();
                                                        }
                                                    }
                                                }
                                                if (check == false)
                                                {
                                                    Console.WriteLine("존재하지 않는 교직원입니다.");
                                                    Console.ReadKey();
                                                }
                                            }
                                    } while (menu != "3");
                                    menu = "0";
                                break;
                        }
                    } while (menu != "2");
                        login = false;
                        Console.Clear();
                    }
                else if (mode == "Staff") {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " 직원모드");
                        Console.WriteLine("1.본인 정보 변경, 2. 본인 정보 확인, 3. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Staff)
                                        {
                                            if ((item as Staff).name == modename && (item as Staff).businessnumber == globalbusnumber)
                                            {
                                                (item as Staff).Pirnt_All_Moment();
                                                check = true;
                                                Console.WriteLine("변경할 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.name = inputstring;
                                                }
                                                Console.WriteLine("변경할 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.phonenumber = inputstring;
                                                }
                                                Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.email = inputstring;
                                                }
                                                    (item as Staff).Pirnt_All_Moment();
                                                Console.WriteLine("변경된 정보를 확인하십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                            case "2":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Staff)
                                        {
                                            if ((item as Staff).name == modename && (item as Staff).businessnumber == globalbusnumber)
                                            {
                                                (item as Staff).Pirnt_All_Moment();
                                                Console.WriteLine("");
                                                check = true;
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                        }
                    } while (menu != "3");
                        login = false;
                        Console.Clear();
                    }
                else if (mode == "Assistant") {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("한남대학교 학교관리 시스템 version 1.0 alpha " + modename + " 조교모드");
                        Console.WriteLine("1.본인 정보 변경, 2.배당 과목 관리, 3.본인 정보 확인, 4. 종료");
                        menu = Console.ReadLine();
                        switch (menu)
                        {
                            case "1":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Assistant)
                                        {
                                            if ((item as Assistant).name == modename && (item as Assistant).businessnumber == globalbusnumber)
                                            {
                                                (item as IPrint).Pirnt_All_Moment();
                                                check = true;
                                                Console.WriteLine("변경할 이름을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.name = inputstring;
                                                }
                                                Console.WriteLine("변경할 전화번호를 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.phonenumber = inputstring;
                                                }
                                                Console.WriteLine("변경할 이메일을 입력하여 주십시오. 공백으로 둘시 변경하지 않습니다.");
                                                inputstring = Console.ReadLine();
                                                if (inputstring != "")
                                                {
                                                    item.email = inputstring;
                                                }
                                                    (item as IPrint).Pirnt_All_Moment();
                                                Console.WriteLine("변경된 정보를 확인하십시오.");
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                            case "2":
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("한남대학교 조교 배당 과목 관리 " + modename + " Admin모드");
                                    Console.WriteLine("1. 배당 과목 확인, 2. 수강생 정보 확인, 3. 나가기");
                                    menu = Console.ReadLine();
                                    if (menu == "1")
                                    {
                                            Console.WriteLine(modename + "조교님의 강의 과목:");
                                            foreach (var item in SubjectList)
                                            {
                                                if (item.subAssistant == modename)
                                                {
                                                    Console.WriteLine(item.subname);
                                                }
                                            }
                                            Console.ReadKey();
                                        }
                                    else if (menu == "2")
                                    {
                                            check = false;
                                            Console.WriteLine("수강생 정보확인을 원하시는 과목을 입력하여주십시오.");
                                            inputstring = Console.ReadLine();
                                            foreach (var item in EnrolmentList)
                                            {
                                                if (item.subname == inputstring && item.subAssistant == modename)
                                                {
                                                    check = true;
                                                    Console.WriteLine(inputstring + " 과목의 수강생정보:");
                                                    Console.WriteLine("학생 이름: " + item.studentname);
                                                    Console.WriteLine("학생 학년: " + item.studentgrade);
                                                    Console.WriteLine("학생 학번: " + item.offerStuID);
                                                    Console.WriteLine("");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (check == false)
                                            {
                                                Console.WriteLine("조교님의 배정강의가 아닙니다.");
                                                Console.ReadKey();
                                            }
                                        }
                                } while (menu != "3");
                                menu = "0";
                                break;
                            case "3":
                                    foreach (var item in SchoolHumanList)
                                    {
                                        if (item is Assistant)
                                        {
                                            if ((item as Assistant).name == modename && (item as Assistant).businessnumber == globalbusnumber)
                                            {
                                                (item as IPrint).Pirnt_All_Moment();
                                                Console.WriteLine("");
                                                check = true;
                                                Console.ReadKey();
                                            }
                                        }
                                    }
                                    menu = "0";
                                break;
                        }
                    } while (menu != "4");
                        login = false;
                        Console.Clear();
                    }
            }
        }
            Console.WriteLine("프로그램 종료");
        }
    }
}
