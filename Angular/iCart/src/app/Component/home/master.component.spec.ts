import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { MasterComponent } from './master.component';

describe('AppComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        MasterComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(MasterComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'ecommerce-web'`, () => {
    const fixture = TestBed.createComponent(MasterComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('ecommerce-web');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(MasterComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('.content span')?.textContent).toContain('ecommerce-web app is running!');
  });
});