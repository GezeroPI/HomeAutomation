import { Component,
  Input,
  Output,
  EventEmitter,
  OnChanges,
  ElementRef,
  ChangeDetectionStrategy,
SimpleChanges } from '@angular/core';
import {
  trigger,
  style,
  animate,
  transition
} from '@angular/animations';
import { select } from 'd3-selection';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {

  constructor() { }
  view: any[] ;

  // options
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  xAxisLabel = 'Time';
  showYAxisLabel = true;
  yAxisLabel = 'Temperature';
  yAxisLabel2 = 'Humidity';
  timeline = true;
  autoScale = true;
  yscaleMin = 10;
  yscaleMax = 38;
  yscaleMin2 = 35;
  yscaleMax2 = 60;
  roundDomains = true;

  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
};
multi: any[] = [
  {
    name: 'Living Room',
    series: [
      {
        name: 8,
        value: 26
      },
      {
        name: 13,
        value: 31      },
      {
        name: 20,
        value: 28
      }
    ]
  },
  {
    name: 'Bedroom',
    series: [
      {
        name: 8,
        value: 25
      },
      {
        name: 13,
        value: 34      },
      {
        name: 20,
        value: 30
      }
    ]
  },
  {
    name: 'Kitchen',
    series: [
      {
        name: 8,
        value: 23
      },
      {
        name: 13,
        value: 32      },
      {
        name: 20,
        value: 28
      }
    ]
  }
];
  
multi2: any[] = [
  {
    name: 'Living Room',
    series: [
      {
        name: 8,
        value: 43
      },
      {
        name: 13,
        value: 47      },
      {
        name: 20,
        value: 55
      }
    ]
  },
  {
    name: 'Bedroom',
    series: [
      {
        name: 8,
        value: 40
      },
      {
        name: 13,
        value: 45      },
      {
        name: 20,
        value: 49
      }
    ]
  },
  {
    name: 'Kitchen',
    series: [
      {
        name: 8,
        value: 44
      },
      {
        name: 13,
        value: 47      },
      {
        name: 20,
        value: 53
      }
    ]
  }
];
}
