using System.Threading.Tasks;
using Model;
using Model.PageModel;
using Model.ViewModel;

namespace Service
{
    public interface IUserInfoService
    {
        /// <summary>
        /// 学生信息添加
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        Task<bool> Create(AddUserInfoViewModel userInfo);


        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="page">当前页码</param>
        /// <param name="limit">显示条数</param>
        /// <param name="userName">用户姓名</param>
        /// <returns></returns>
        Task<PageSearchModel> GetPageListData(int page = 1, int limit = 15, string userName = "");

        /// <summary>
        /// 学生信息修改
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        Task<bool> Update(UserInfo userInfo);

        /// <summary>
        /// 学生信息删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> Delete(int? id);

        /// <summary>
        /// 查找用户详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserInfo> QueryUserInfoDetail(int id);
    }
}
