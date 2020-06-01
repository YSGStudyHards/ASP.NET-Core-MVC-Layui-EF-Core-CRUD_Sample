using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.ViewModel;
using Service;

namespace EFCore_MySQL_CURD_Sample.Controllers
{
    /// <summary>
    /// 数据操作API
    /// </summary>
    public class OperationApiController : Controller
    {

        private readonly IUserInfoService _userInfoService;

        public OperationApiController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }


        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="page">当前页码</param>
        /// <param name="limit">显示条数</param>
        /// <param name="userName">用户姓名</param>
        /// <returns></returns>
        public async Task<IActionResult> GetUserInfo(int page = 1, int limit = 15, string userName = "")
        {
            var result = await _userInfoService.GetPageListData(page, limit, userName);

            if (result.Code == 200)
            {
                return Json(new { code = 0, count = result.TotalCount, data = result.DataList });
            }
            else
            {
                return Json(new { code = 1, resultMsg = result.ResultMsg });
            }
        }


        /// <summary>
        /// 信息添加
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddUserInfo(/*[FromBody]*/AddUserInfoViewModel userInfo)
        {
            var result = await _userInfoService.Create(userInfo);

            return Json(result ? new { code = 0, resultMsg = "添加成功" } : new { code = 1, resultMsg = "网络打瞌睡了！" });
        }


        /// <summary>
        /// 数据更新
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public async Task<IActionResult> UpdateUserInfo(UserInfo userInfo)
        {
            var result = await _userInfoService.Update(userInfo);

            return Json(result ? new { code = 0, resultMsg = "更新成功" } : new { code = 1, resultMsg = "网络打瞌睡了！" });
        }

        /// <summary>
        /// 数据删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> DataDelete(int? id)
        {
            var result = await _userInfoService.Delete(id);

            return Json(result ? new { code = 0, resultMsg = "删除成功" } : new { code = 1, resultMsg = "网络打瞌睡了！" });
        }

        /// <summary>
        /// 获取数据记录详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> QueryUserInfoDetail(int id)
        {
            var result = await _userInfoService.QueryUserInfoDetail(id);

            return Json(result!=null? new { code = 0, resultMsg = "删除成功" } : new { code = 1, resultMsg = "网络打瞌睡了！" });
        }
    }
}