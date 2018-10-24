// NOTE
// 类似 Dota 技能

// Ability - 参考 Dota
// 时间统一采用 ms 单位

// 技能分为主动技能，或者被动技能
// 采用数据驱动的方式，配置 xml/json

// DOTA 技能释放方式：
// 无目标：比如宙斯W
// 指向某个区域：比如牛头F
// 指向某个人：比如冰女W

// 面向手机的操作方式:
// 选择技能，点击目标
// 这样的好处是选择技能之后能够标记出可供释放的目标，减少操作的试错

// ROADMAP:
// 先实现 skill
// 再实现一个技能带多种效果 (回复血同时 + 攻击力加成) - 一个 skill 包含多个 ability
// 最后可实现数据驱动（配置 + 自由组合）

// Buff - 增强技能/属性
// Debuff - 降低技能/属性

// 实现技能
// 加血 - Heal
// 中毒 - Debuff
// 沉默 - Debuff
// 冰冻 
// 持续掉血
// 攻击力加强 - Buff


// LINK:
// https://www.jianshu.com/p/7c03920240de
// https://gamedev.stackexchange.com/questions/62974/c-design-for-ability-system
// https://bbs.gameres.com/thread_453222_1_1.html