using WebAPICoreEntity.Model;

namespace WebAPICoreEntity.Services
{
    public class StudentService:IStudentService
    {
        private readonly StudentDbContext _context;
        public StudentService(StudentDbContext context) 
        { 
          _context=context;
        }

        public ResponseModel DeleteStudent(int stdId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Students _temp = GetStudentsDetailsById(stdId);
                if (_temp != null)
                {
                    _context.Remove<Students>(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Student Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Student Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public Students GetStudentsDetailsById(int stdId)
        {
            try
            {
                var std = _context.Find<Students>(stdId);
                return std;
            }
            catch
            {
                throw;
            }
        }

        public List<Students> GetStudentsList()
        {
            try
            {
                var std = _context.Set<Students>().ToList();
                return std;
            }
            catch
            {
                throw;
            }
        }

        public ResponseModel SaveStudents(Students students)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Students _temp = GetStudentsDetailsById(students.Id);
                if (_temp != null)
                {
                    _temp.StudentName = students.StudentName;
                    _temp.StudentEmail = students.StudentEmail;
                    _temp.StudentMobile = students.StudentMobile;
                    _context.Update<Students>(_temp);
                    model.Messsage = "Student Update Successfully";
                }
                else
                {
                    _context.Add<Students>(students);
                    model.Messsage = "Student Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
    }
}
