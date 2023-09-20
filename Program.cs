public abstract class AviationBase
{
	int _max_horizontal_speed;
	int _max_flying_high;
}

public abstract class WingsBase: AviationBase
{
	int _wingspan;
}

public class Fighter_aircraft: WingsBase, IHorizontal_takeoff
{
	int _afterburner_speed;
}

public class Helicopter: AviationBase, IVertical_takeoff
{
	int _takeoff_speed;
	int _number_of_screws;
}

public class Bomber_aircraft: WingsBase, IHorizontal_takeoff
{
	double _max_payload;
}

public class Tiltrotor: WingsBase, IHorizontal_takeoff, IVertical_takeoff
{
	int _vertical_takeoff_speed;
}

public class Quadrocopter: AviationBase, IVertical_takeoff
{
	string _type;
	string _management_protocol;
}

public interface IVertical_takeoff
{
    public int takeoff_speed;{ get; set; }
    public int vertical_takeoff_speed;{ get; set; }
}

public interface IHorizontal_takeoff
{
    public int wingspan { get; set; }
}
/* 
 8. Авиация. Необходимо иметь возможность отдельно группировать системы с вертикальным взлётом и системы с горизонтальным взлётом.
Самолет-истребитель
	Максимальная горизонтальная скорость  
	Максимальная высота полета  
	Размах крыльев  
	Скорость на форсаже  
Вертолет
	Скорость взлёта  
	Максимальная высота полета  
	Количество винтов  
	Максимальная горизонтальная скорость  
Самолёт-бомбардировщик
	Максимальная горизонтальная скорость  
	Максимальная высота полета  
	Максимальная полезная нагрузка  
	Размах крыльев  
Конвертоплан
	Максимальная горизонтальная скорость  
	Скорость вертикального взлёта  
	Максимальная высота полета  
	Размах крыльев  	 
БПЛА-квадрокоптер
	Максимальная горизонтальная скорость
	Максимальная высота полёта
	Тип 
	Протокол управления
	Скорость вертикального взлёта
 */
