using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG;

public static class Logic
{
    public static async Task ExecuteSequenceAsync<T>(T Naruto, T Recca, Func<string,Task> writeAsync) where T : IAttackable, IAttacker
    {
        //1. Naruto attacks Recca with first attack
        var result = Naruto.Attack(Recca);
        await PrintAttackResultAsync(result);

        //2. Recca moves away from Naruto
        Recca.MoveTo(5, 5);
        await PrintMovementAsync(Recca);

        //3. Naruto attacks Recca a second time
        var result2 = Naruto.Attack(Recca);
        await PrintAttackResultAsync(result2);

        //4. Recca moves further away from Naruto
        Recca.MoveTo(20, 20);
        await PrintMovementAsync(Recca);

        //5. Naruto attacks Recca a third time
        var result3 = Naruto.Attack(Recca);
        await PrintAttackResultAsync(result3);

        //6. Recca strikes back from a distance
        var result4 = Recca.Attack(Naruto);
        await PrintAttackResultAsync(result4);
        //output

        async Task PrintAttackResultAsync(AttackResult attackResult)
        {
            if (attackResult.Succeeded) {
                await writeAsync($"{attackResult.Attacker} hits {attackResult.Target} using {attackResult.Weapon} at distance: {attackResult.Distance}...{Environment.NewLine}");

            }
            else
            {
                await writeAsync($"{attackResult.Attacker} misses {attackResult.Target} using {attackResult.Weapon} at distance: {attackResult.Distance}...{Environment.NewLine}");
            }
        }

        async Task PrintMovementAsync(IAttackable ninja)
        {
            await writeAsync($"{ninja.Name} moved to: {ninja.Position}. {Environment.NewLine}");
        }
    }
}
