using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Manager Class (implementation detail, spawned automatically and updates all registered timers)


/// <summary>
/// Manages updating all the <see cref="Timer"/>s that are running in the application.
/// This will be instantiated the first time you create a timer -- you do not need to add it into the
/// scene manually.
/// </summary>
public class TimerManager : MonoBehaviour
{
    private List<Timer> _timers = new List<Timer>();

    // buffer adding timers so we don't edit a collection during iteration
    private List<Timer> _timersToAdd = new List<Timer>();

    public void RegisterTimer(Timer timer)
    {
        this._timersToAdd.Add(timer);
    }

    public void CancelAllTimers()
    {
        foreach (Timer timer in this._timers)
        {
            timer.Cancel();
        }

        this._timers = new List<Timer>();
        this._timersToAdd = new List<Timer>();
    }

    // update all the registered timers on every frame
    //[UsedImplicitly]
    private void Update()
    {
        this.UpdateAllTimers();
    }

    private void UpdateAllTimers()
    {
        if (this._timersToAdd.Count > 0)
        {
            this._timers.AddRange(this._timersToAdd);
            this._timersToAdd.Clear();
        }

        foreach (Timer timer in this._timers)
        {
            timer.Update();
        }

        this._timers.RemoveAll(t => t.isDone);
    }

    private void OnDestroy()
    {
        CancelAllTimers();
    }
}

#endregion