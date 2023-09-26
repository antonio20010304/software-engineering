namespace name;

public abstract class AviationBase
{
    int MaxHorizontalSpeed { get; set; }
    public int MaxFlyingHigh { get; set; }
}

public abstract class WingsBase : AviationBase
{
    public int Wingspan { get; set; }
}

public class Fighter_aircraft : WingsBase, IHorizontal_takeoff
{
    public int AfterburnerSpeed { get; set; }
}

public class Helicopter : AviationBase, IVertical_takeoff
{
    public int NumberOfScrews { get; set; }

    public int TakeoffSpeed { get ; set; }
    public int VerticalTakeoffSpeed { get ; set; }
}

public class Bomber_aircraft : WingsBase, IHorizontal_takeoff
{
    double _maxPayload;

}

public class Tiltrotor : WingsBase, IHorizontal_takeoff, IVertical_takeoff
{
    public int TakeoffSpeed { get ; set; }
    public int VerticalTakeoffSpeed { get ; set; }
}

public class Quadrocopter : AviationBase, IVertical_takeoff
{
    public string Type { get ; set; }
    public string ManagementProtocol { get ; set; }

    public int TakeoffSpeed { get ; set; }
    public int VerticalTakeoffSpeed { get ; set; }

}

public interface IVertical_takeoff
{
    public int TakeoffSpeed{ get; set; }
    public int VerticalTakeoffSpeed{ get; set; }
}

public interface IHorizontal_takeoff
{
    public int Wingspan { get; set; }
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
