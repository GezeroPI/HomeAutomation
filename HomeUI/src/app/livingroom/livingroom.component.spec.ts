import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LivingroomComponent } from './livingroom.component';

describe('LivingroomComponent', () => {
  let component: LivingroomComponent;
  let fixture: ComponentFixture<LivingroomComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LivingroomComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LivingroomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
