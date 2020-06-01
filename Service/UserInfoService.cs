using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.PageModel;
using Model.ViewModel;


namespace Service
{
    public class UserInfoService : IUserInfoService
    {
        private readonly SchoolUserInfoContext _shoSchoolUserInfoContext;

        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="schoolUserInfoContext"></param>
        public UserInfoService(SchoolUserInfoContext schoolUserInfoContext)
        {
            _shoSchoolUserInfoContext = schoolUserInfoContext;
        }

        /// <summary>
        /// 学生信息添加
        /// </summary>
        /// <param name="addUserInfo"></param>
        /// <returns></returns>
        public async Task<bool> Create(AddUserInfoViewModel addUserInfo)
        {
            try
            {
                var userInfo=new UserInfo()
                {
                    UserName = addUserInfo.UserName,
                    Sex = addUserInfo.Sex,
                    Hobby = addUserInfo.Hobby,
                    Phone = addUserInfo.Phone,
                    Description = addUserInfo.Description
                };

                _shoSchoolUserInfoContext.UserInfos.Add(userInfo);

                await _shoSchoolUserInfoContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="page">当前页码</param>
        /// <param name="limit">显示条数</param>
        /// <param name="userName">用户姓名</param>
        /// <returns></returns>
        public async Task<PageSearchModel> GetPageListData(int page = 1, int limit = 15, string userName = "")
        {
            try
            {
                List<UserInfo> listData;
                var totalCount = 0;
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    listData = await _shoSchoolUserInfoContext.UserInfos.Where(x => x.UserName.Contains(userName)).OrderByDescending(x => x.Id).Skip((page - 1) * limit).Take(limit).ToListAsync();

                    totalCount = _shoSchoolUserInfoContext.UserInfos
                        .Count(x => x.UserName.Contains(userName));
                }
                else
                {
                    listData = await _shoSchoolUserInfoContext.UserInfos.OrderByDescending(x => x.Id).Skip((page - 1) * limit).Take(limit).ToListAsync();

                    totalCount = _shoSchoolUserInfoContext.UserInfos.Count();
                }

                return new PageSearchModel()
                {
                    ResultMsg = "success",
                    Code = 200,
                    TotalCount = totalCount,
                    DataList = listData
                };
            }
            catch (Exception e)
            {
                return new PageSearchModel() { Code = 400, ResultMsg = e.Message };
            }
        }

        /// <summary>
        /// 学生信息修改
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public async Task<bool> Update(UserInfo userInfo)
        {

            try
            {
                _shoSchoolUserInfoContext.UserInfos.Update(userInfo);

                await _shoSchoolUserInfoContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 学生信息删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Delete(int? id)
        {
            try
            {
                var searchUserInfo = await _shoSchoolUserInfoContext.UserInfos.FindAsync(id);

                if (searchUserInfo == null)
                {
                    return false;
                }

                _shoSchoolUserInfoContext.UserInfos.Remove(searchUserInfo);
                await _shoSchoolUserInfoContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// 查找用户详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserInfo> QueryUserInfoDetail(int id)
        {
            return await _shoSchoolUserInfoContext.UserInfos.FindAsync(id);
        }
    }
}
