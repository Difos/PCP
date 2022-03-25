using PCP.Domain.Entities;
using PCP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCP.Infra.Repositories
{
    public class TrocasxSurgimentoVigenteRepository : RepositoryBase<TrocasxSurgimentoVigente>, ITrocasxSurgimentoVigenteRepository
    {
        public List<TrocasxSurgimentoVigente> GetTrocas()
        {
            return Db.Database.SqlQuery<TrocasxSurgimentoVigente>("select * from TrocasxSurgimentoVigente").ToList();
        }

        public List<TrocaRodeirosTurno> GetTrocasTurno()
        {
            return Db.Database.SqlQuery<TrocaRodeirosTurno>("select * from TrocaRodeirosTurno").ToList();
        }

        public List<ResultAllTrocas> GetTrocasDetail(string data)
        {
            return Db.Database.SqlQuery<ResultAllTrocas>(string.Format(@"with horasPro as 
                                                        (
                                                        select 

                                                        case when convert(time,fim) between '00:00' and '00:59' then '00h' end as [00h],
                                                        case when convert(time,fim) between '01:00' and '01:59' then '01h' end as [01h],
                                                        case when convert(time,fim) between '02:00' and '02:59' then '02h' end as [02h],
                                                        case when convert(time,fim) between '03:00' and '03:59' then '03h' end as [03h],
                                                        case when convert(time,fim) between '04:00' and '04:59' then '04h' end as [04h],
                                                        case when convert(time,fim) between '05:00' and '05:59' then '05h' end as [05h],
                                                        case when convert(time,fim) between '06:00' and '06:59' then '06h' end as [06h],
                                                        case when convert(time,fim) between '07:00' and '07:59' then '07h' end as [07h],
                                                        case when convert(time,fim) between '08:00' and '08:59' then '08h' end as [08h],
                                                        case when convert(time,fim) between '09:00' and '09:59' then '09h' end as [09h],
                                                        case when convert(time,fim) between '10:00' and '10:59' then '10h' end as [10h],
                                                        case when convert(time,fim) between '11:00' and '11:59' then '11h' end as [11h],
                                                        case when convert(time,fim) between '12:00' and '12:59' then '12h' end as [12h],
                                                        case when convert(time,fim) between '13:00' and '13:59' then '13h' end as [13h],
                                                        case when convert(time,fim) between '14:00' and '14:59' then '14h' end as [14h],
                                                        case when convert(time,fim) between '15:00' and '15:59' then '15h' end as [15h],
                                                        case when convert(time,fim) between '16:00' and '16:59' then '16h' end as [16h],
                                                        case when convert(time,fim) between '17:00' and '17:59' then '17h' end as [17h],
                                                        case when convert(time,fim) between '18:00' and '18:59' then '18h' end as [18h],
                                                        case when convert(time,fim) between '19:00' and '19:59' then '19h' end as [19h],
                                                        case when convert(time,fim) between '20:00' and '20:59' then '20h' end as [20h],
                                                        case when convert(time,fim) between '21:00' and '21:59' then '21h' end as [21h],
                                                        case when convert(time,fim) between '22:00' and '22:59' then '22h' end as [22h],
                                                        case when convert(time,fim) between '23:00' and '23:59' then '23h' end as [23h],Linha 

                                                         from db_perdasCtr.dbo.perdas where atividade='Troca de rodeiro' and data=convert(date,'{0}') 
                                                             and vagao<> '' and posicao<> ''
                                                        ) , alllinhas as 
                                                        (

                                                        SELECT 'TR-1' as linha, COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h], COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-1'

                                                        union all

                                                        SELECT 'TR-2', COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h], COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-2'

                                                        union all

                                                        SELECT 'TR-3',COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h] , COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-3'
                                                        union all

                                                        SELECT 'TR-4',COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h],COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-4'

                                                        union all

                                                        SELECT 'TR-5',COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h], COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-5'
                                                        union all 

                                                        SELECT 'TR-6' as linha,COUNT([00h]) as [00h],
                                                        COUNT([01h]) as [01h],
                                                        COUNT([02h])  as [02h] ,
                                                        COUNT([03h])  as [03h] ,
                                                        COUNT([04h])  as [04h],
                                                        COUNT([05h])  as [05h],
                                                        COUNT([06h])  as [06h],
                                                        COUNT([07h])  as [07h],
                                                        COUNT([08h])  as [08h],
                                                        COUNT([09h])  as [09h],
                                                        COUNT([10h])  as [10h],
                                                        COUNT([11h])  as [11h],
                                                        COUNT([12h])  as [12h],
                                                        COUNT([13h])  as [13h],
                                                        COUNT([14h])  as [14h],
                                                        COUNT([15h])  as [15h],
                                                        COUNT([16h])  as [16h],
                                                        COUNT([17h])  as [17h],
                                                        COUNT([18h])  as [18h],
                                                        COUNT([19h])  as [19h],
                                                        COUNT([20h])  as [20h],
                                                        COUNT([21h])  as [21h],
                                                        COUNT([22h])  as [22h],
                                                        COUNT([23h])  as [23h],  COUNT([00h])+COUNT([01h])+COUNT([02h])+COUNT([03h])+COUNT([04h])+COUNT([05h])+COUNT([06h])+COUNT([07h])+COUNT([08h])+COUNT([09h])+COUNT([10h])+COUNT([11h])+COUNT([12h])+COUNT([13h])+COUNT([14h])+COUNT([15h])+COUNT([16h])+COUNT([17h])+COUNT([18h])+COUNT([19h])+COUNT([20h])+COUNT([21h])+COUNT([22h])+COUNT([23h]) as total from horasPro where linha='TR-6'
                                                        
                                                        )select '' as Id, linha,[00h] as [a00h],
                                                        [01h] as [a01h],
                                                        [02h] as [a02h],
                                                        [03h] as [a03h],
                                                        [04h] as [a04h],
                                                        [05h] as [a05h],
                                                        [06h] as [a06h],
                                                        [07h] as [a07h],
                                                        [08h] as [a08h],
                                                        [09h] as [a09h],
                                                        [10h] as [a10h],
                                                        [11h] as [a11h],
                                                        [12h] as [a12h],
                                                        [13h] as [a13h],
                                                        [14h] as [a14h],
                                                        [15h] as [a15h],
                                                        [16h] as [a16h],
                                                        [17h] as [a17h],
                                                        [18h] as [a18h],
                                                        [19h] as [a19h],
                                                        [20h] as [a20h],
                                                        [21h] as [a21h],
                                                        [22h] as [a22h],
                                                        [23h] as [a23h], total  from alllinhas 
                                                        union all
                                                        
                                                        select  '' as Id, 'Total' as linha,SUM([00h]) as [a00h],
                                                        
                                                        sum([01h]) as [a01h],
                                                        sum([02h]) as [a02h],
                                                        sum([03h]) as [a03h],
                                                        sum([04h])as [a04h],
                                                        sum([05h])as [a05h],
                                                        sum([06h])as [a06h],
                                                        sum([07h])as [a07h],
                                                        sum([08h])as [a08h],
                                                        sum([09h])as [a09h],
                                                        sum([10h])as [a10h],
                                                        sum([11h])as [a11h],
                                                        sum([12h])as [a12h],
                                                        sum([13h])as [a13h],
                                                        sum([14h])as [a14h],
                                                        sum([15h])as [a15h],
                                                        sum([16h])as [a16h],
                                                        sum([17h])as [a17h],
                                                        sum([18h])as [a18h],
                                                        sum([19h])as [a19h],
                                                        sum([20h])as [a20h],
                                                        sum([21h])as [a21h],
                                                        sum([22h])as [a22h],
                                                        sum([23h])as [a23h], sum(total) from alllinhas", data)).ToList();
        }
    }
}
