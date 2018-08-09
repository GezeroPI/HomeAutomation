import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BackbalconyComponent } from './backbalcony.component';

describe('BackbalconyComponent', () => {
  let component: BackbalconyComponent;
  let fixture: ComponentFixture<BackbalconyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BackbalconyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BackbalconyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
