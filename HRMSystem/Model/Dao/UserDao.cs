using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserDao
    {
        HRMS_DbContext db = null;
        public UserDao()
        {
            db = new HRMS_DbContext();
        }

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.BusinessPartner_ID = entity.BusinessPartner_ID;
                user.UserName = entity.UserName;
                if (!string.IsNullOrEmpty(entity.PassWord))
                {
                    user.PassWord = entity.PassWord;
                }
                user.ModifiedBy = entity.ModifiedBy;
                user.ModifiedDate = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        public IEnumerable<User> ListAllPaging(string searchString, int pageNumber, int pageSize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString)||x.FullName.Contains(searchString));
            }
            return model.OrderByDescending(x=>x.CreatedDate).ToPagedList(pageNumber,pageSize);
        }

        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        
        public User ViewDetail(int id)
        {
            //Phương thức tìm kiếm theo khóa chính  
            return db.Users.Find(id);
        }

        //Login/
        public int Login(string userName, string passWord)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName && x.PassWord == passWord);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.PassWord == passWord)
                    {
                        return 1;
                    }
                    else return -2;
                }
            }
        }

        public bool ForgotPassword(string userName)
        {
            var result = db.Users.Count(x => x.UserName == userName);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ResetPassword(string passWord, string ConfirmPassword)
        {
            var result = db.Users.SingleOrDefault(x => x.PassWord == passWord && x.ConfirmPassword == ConfirmPassword);
            if (result==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
