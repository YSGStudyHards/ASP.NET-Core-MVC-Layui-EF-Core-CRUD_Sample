/*
 Navicat Premium Data Transfer
 Source Server Type    : MySQL
 Source Server Version : 50726
 Date: 01/06/2020 23:20:04
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for UserInfo
-- ----------------------------
DROP TABLE IF EXISTS `UserInfo`;
CREATE TABLE `UserInfo`  (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT '学生编号',
  `UserName` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL COMMENT '学生姓名',
  `Sex` varchar(4) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '学生性别',
  `Phone` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '学生联系电话',
  `Description` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '个人描述',
  `Hobby` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL COMMENT '个人爱好',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci COMMENT = '学生信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of UserInfo
-- ----------------------------
INSERT INTO `UserInfo` VALUES (1, '刘德华', '男', '88888888', '大帅哥一个！', '唱歌');
INSERT INTO `UserInfo` VALUES (2, '小红', '女', '666666', '是个乐观开朗的小女孩！！', '化妆');
INSERT INTO `UserInfo` VALUES (3, 'COCO', '女', '999999', '舞蹈是人生中必不可少的乐趣', '跳舞');
INSERT INTO `UserInfo` VALUES (4, '小哈', '男', '9999', '喜爱运动，乐观开朗', '打篮球');
INSERT INTO `UserInfo` VALUES (5, '追逐时光者', '男', '168888', '一个帅气小伙', '写博客，分享文章');
INSERT INTO `UserInfo` VALUES (6, '小美丽', '男', '888888', '看书', '学习');
INSERT INTO `UserInfo` VALUES (7, 'Edwin', '男', '999999', '乐观开朗，热爱学习，热爱运动', '打乒乓球');

SET FOREIGN_KEY_CHECKS = 1;
