using WebAPICoreEntity.Model;

namespace WebAPICoreEntity.Services
{
    public interface IStudentService
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        List<Students> GetStudentsList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stdId"></param>
        /// <returns></returns>
        Students GetStudentsDetailsById(int stdId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        ResponseModel SaveStudents(Students students);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="stdId"></param>
        /// <returns></returns>
        ResponseModel DeleteStudent(int stdId);
    }
}
