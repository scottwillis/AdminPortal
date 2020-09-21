import { Component } from '@angular/core';

@Component({
  selector: 'app-stats-component',
  templateUrl: './stats.component.html'
})
export class StatsComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
