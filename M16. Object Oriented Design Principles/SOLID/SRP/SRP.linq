<Query Kind="Statements" />

//**************************************************
//Смысл принципа: 
//Борьба со сложностью, важность которой резко возрастает
//при развитии логики приложения.
//**************************************************

//Типичные примеры нарушения SRP
// - смешивание логики с инфраструктурой. Бизнес-логика смешана 
//с представлением, слоем персистентности, находится внутри
//WCF или Windows-сервисов. Должна быть возможность сосредоточиться
//на бизнес-правилах, не обращая внимания на второстепенные 
//инфраструктурные детали;
// - слабая связность(low cohesion). Класс / модуль / метод 
//не является цельным и решает несколько несвязанных задач.
//Проявляются несколько групп методов, каждая из которых 
//обращается к подмножеству полей, не используемых другими методами;
// - выполнение нескольких несвязанных задач. Класс/модуль может
//быть цельным, но решать несколько несвязанных задач 
//(вычисление заработной платы и построение отчета). 
//Класс / модуль / метод должен быть сфокусированным на решении 
//минимального числа задач;
// - решение задач разных уровней абстракции. Класс/метод не должен
//отвечать за задачи разного уровня. Например, класс удаленного
//заместителя не должен самостоятельно проверять аргументы, 
//заниматься сериализацией и шифрованием. Каждый из этих 
//аспектов должен решаться отдельным классом.