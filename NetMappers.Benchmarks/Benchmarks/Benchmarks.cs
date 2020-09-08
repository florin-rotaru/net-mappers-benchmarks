using Models;

namespace NetMappers.Benchmarks
{
    public class From_TC0_Members_To_TC0_I0_Members : FromToN0<TC0_Members, TC0_I0_Members> { }
    public class From_TC0_Members_To_TC0_I1_Members : FromToN0<TC0_Members, TC0_I1_Members> { }
    public class From_TC0_Members_To_TC0_I2_Nullable_Members : FromToN0<TC0_Members, TC0_I2_Nullable_Members> { }

    public class From_TC0_Members_To_TS0_I0_Members : FromToN0<TC0_Members, TS0_I0_Members> { }
    public class From_TC0_Members_To_TS0_I1_Members : FromToN0<TC0_Members, TS0_I1_Members> { }
    public class From_TC0_Members_To_TS0_I2_Nullable_Members : FromToN0<TC0_Members, TS0_I2_Nullable_Members> { }


    public class From_TS0_Members_To_TC0_I0_Members : FromToN0<TS0_Members, TC0_I0_Members> { }
    public class From_TS0_Members_To_TC0_I1_Members : FromToN0<TS0_Members, TC0_I1_Members> { }
    public class From_TS0_Members_To_TC0_I2_Nullable_Members : FromToN0<TS0_Members, TC0_I2_Nullable_Members> { }

    public class From_TS0_Members_To_TS0_I0_Members : FromToN0<TS0_Members, TS0_I0_Members> { }
    public class From_TS0_Members_To_TS0_I1_Members : FromToN0<TS0_Members, TS0_I1_Members> { }
    public class From_TS0_Members_To_TS0_I2_Nullable_Members : FromToN0<TS0_Members, TS0_I2_Nullable_Members> { }


    public class From_TC1_To_TC1_0 : FromToN1<TC1, TC1_0> { }
    public class From_TC1_To_TS1_0 : FromToN1<TC1, TS1_0> { }

    public class From_TS1_To_TC1_0 : FromToN1<TS1, TC1_0> { }
    public class From_TS1_To_TS1_0 : FromToN1<TS1, TS1_0> { }
}
